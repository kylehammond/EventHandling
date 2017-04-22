using StrangerEventsTesting.Characters;

namespace StrangerEventsTesting
{
    public class JoyceByers : Character
    {
        public JoyceByers() : base("Joyce Byers") { }

        public void OnCriedForHelp(object sender, CryEventArgs e)
        {
            Disp.A();

            if (e.CryType == CryType.ChristmasLights)
                Disp.WL("Joyce heard the message from " + e.CrierName + " in the Christmas Lights!");

            if (e.CryType == CryType.ExplodingPhone)
                Disp.WL("Joyce heard the garbled message from " + e.CrierName + " and let the phone explode in her face!");

            if (e.CryType == CryType.UpsideDown)
                Disp.WL("Joyce heard the faint voice of " + e.CrierName + "!");
        }
    }
}