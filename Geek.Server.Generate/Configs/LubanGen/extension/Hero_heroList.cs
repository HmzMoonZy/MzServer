namespace HotFix.Cfg
{
    public partial class Hero_heroList
    {
        public Hero_heroList(int id, int quality, int memberId, string nameID, int atlasID, string cardIcon)
        {
            this.id = id;
            this.quality = quality;
            this.memberId = memberId;
            this.nameID = nameID;
            this.atlasID = atlasID;
            this.cardIcon = cardIcon;
        }
    }
}