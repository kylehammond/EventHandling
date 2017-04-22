namespace StrangerEventsTesting.Characters
{
    internal class FriendOfWill : Character
    {
        public FriendOfWill(string name) : base(name) { }

        public void OnCriedForHelp(object sender, CryEventArgs e)
        {
            Disp.A();

            if (e.CryType == CryType.Walkie)
                Disp.WL(Name + " heard the message from " + e.CrierName + " over the walkie talkie!");

            if (e.CryType == CryType.UpsideDown)
                Disp.WL(Name + " heard the message from " + e.CrierName + " telepathically from the Upside Down!");
        }
    }
}