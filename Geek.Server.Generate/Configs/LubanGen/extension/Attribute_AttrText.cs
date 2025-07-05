namespace HotFix.Cfg
{
    public partial class Attribute_AttrText
    {
        public Attribute_AttrText(int iconAtlasID, string iconName)
        {
            this.iconAtlasID = iconAtlasID;
            this.iconName = iconName;
        }

        public Attribute_AttrText(string id)
        {
            this.LanguageId = "";
            this.ID = id;
        }
    }
}