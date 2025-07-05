namespace HotFix.Cfg
{
    public partial class ChainPacks_ChainPacks
    {
        public ChainPacks_ChainPacks(int id, int group, int condition, int purchaseId, string[] rewards)
        {
            this.id = id;
            this.group = group;
            this.condition = condition;
            PurchaseId = purchaseId;
            this.rewards = rewards;
        }
    }
}