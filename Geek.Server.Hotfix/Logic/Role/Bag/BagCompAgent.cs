
using Geek.Server.App.Common.Event;
using Geek.Server.App.Logic.Role.Bag;
using Geek.Server.Core.Hotfix.Agent;
using Geek.Server.Core.Utils;
using Server.Logic.Common.Events;
using Server.Logic.Logic.Role.Base;

namespace Server.Logic.Logic.Role.Bag
{
    public class BagCompAgent : StateCompAgent<BagComp, BagState>
    {
        readonly NLog.Logger LOGGER = NLog.LogManager.GetCurrentClassLogger();

        public override void Active()
        {
            if (State.ItemMap.Count <= 0)
            {
                State.ItemMap.Add(101, 1);
                State.ItemMap.Add(103, 100);
            }
        }

        private ResBagInfo BuildInfoMsg()
        {
            var res = new ResBagInfo();
            foreach (var kv in State.ItemMap)
                res.ItemDic[kv.Key] = kv.Value;
            return res;
        }

        public async Task GetBagInfo(ReqBagInfo reqMsg)
        {
            var ret = BuildInfoMsg();
            await this.NotifyClient(ret, reqMsg.UniId);
        }
    }
}
