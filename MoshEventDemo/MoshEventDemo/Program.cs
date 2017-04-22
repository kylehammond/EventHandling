using System;
using StrangerEventsTesting.Characters;

namespace StrangerEventsTesting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var will = new Cryer("Will Byers");
            var barb = new Cryer("Barb Holland");
            var joyce = new JoyceByers();
            var mike = new FriendOfWill("Mike Wheeler");
            var dustin = new FriendOfWill("Dustin Henderson");
            var lucas = new FriendOfWill("Lucas Sinclair");
            var eleven = new FriendOfWill("Eleven");

            RegisterFriendsComms(will, joyce, mike, dustin, lucas, eleven);

            // title screen and cue music
            Disp.ShowTitleScreen();

            // cries for help!
            CryForHelp(will, barb);

            Disp.WL("The end");
            Console.ReadKey();
        }

        private static void RegisterFriendsComms(Cryer will, JoyceByers joyce, FriendOfWill mike, FriendOfWill dustin, FriendOfWill lucas, FriendOfWill eleven)
        {
            // things joyce can hear
            will.CriedWithChristmasLights += joyce.OnCriedForHelp;
            will.CriedIntoExplodingPhone += joyce.OnCriedForHelp;
            will.CriedFromTheUpsideDown += joyce.OnCriedForHelp;

            // things wills friends can hear
            will.CriedToWalkieTalkie += mike.OnCriedForHelp;
            will.CriedToWalkieTalkie += dustin.OnCriedForHelp;
            will.CriedToWalkieTalkie += lucas.OnCriedForHelp;
            will.CriedToWalkieTalkie += eleven.OnCriedForHelp;
            will.CriedFromTheUpsideDown += eleven.OnCriedForHelp;
        }

        private static void CryForHelp(Cryer will, Cryer barb)
        {
            will.CryForHelp("blink blink blinkblink... blink blink..!", CryType.ChristmasLights);
            will.CryForHelp("Help I'm in the upsidedown!", CryType.Walkie);
            barb.CryForHelp("Help I'm being bullied!", CryType.SideOfPool);
            will.CryForHelp("In 15 seconds this message will self destruct!", CryType.ExplodingPhone);
            barb.CryForHelp("Help I'm forgettable!", CryType.UpsideDown);
        }
    }
}