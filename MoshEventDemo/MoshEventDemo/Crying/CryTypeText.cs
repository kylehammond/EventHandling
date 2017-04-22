using System.Collections.Generic;

namespace StrangerEventsTesting.Crying
{
    public class CryTypeText : Dictionary<CryType, string>
    {
        public CryTypeText()
        {
            Add(CryType.ChristmasLights, "the Christmas lights");
            Add(CryType.ExplodingPhone, "an exploding phone");
            Add(CryType.SideOfPool, "the side of the pool");
            Add(CryType.UpsideDown, "the Upside Down");
            Add(CryType.Walkie, "a walkie talkie");
        }
    }
}