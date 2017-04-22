using System;
using System.Threading;

namespace StrangerEventsTesting
{
    /// <summary>
    /// I would never name things like this in real life.  This is just for fun.
    /// </summary>
    internal static class Disp
    {
        /// <summary>
        /// Clear screen
        /// </summary>
        private static void C()
        {
            Console.Clear();
        }

        /// <summary>
        /// Write Line
        /// </summary>
        /// <param name="text">Text to write to line</param>
        public static void WL(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Write
        /// </summary>
        /// <param name="text">Text to write</param>
        public static void W(string text)
        {
            Console.Write(text);
        }

        /// <summary>
        /// Sleep
        /// </summary>
        /// <param name="timeout">How long to sleep</param>
        public static void S(int timeout)
        {
            Thread.Sleep(timeout);
        }

        /// <summary>
        /// New blank line
        /// </summary>
        public static void N()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Arrows
        /// </summary>
        public static void A()
        {
            W(">>>> ");
        }

        /// <summary>
        /// Show amazing ASCII title 
        /// </summary>
        public static void ShowTitleScreen()
        {
            WL("Begin music - *incredibly awesome synth baseline arpeggiates...*");
            S(4000); N(); N(); N(); N();
            WL(" -oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo`  ");
            WL(" `...-:///::-...........................................................--....................................   ");
            WL("   :smmNmmmmdyy:hyyyyyyyyyy-syyyyyyyyyo:    `syyyy/   +yyyyyy/ /yy+`-ohdmddhyso  -syyyyyyyyh+.sdddddddddddhy+.   ");
            WL("  oNMMN+-../yNdyd+:mMMMo/yN.yMMMd::yMMMN`   .NMMMMs   `MNMMMMy` mM-hNMMh:..:omd   yMMMm-.-+hm .MMMMMh//sNMMMMd   ");
            WL(" .MMMMh      -:s`  mMMM/  :/sMMMs  +MMMy    yNoMMMN.   Md/mMMMd-dMoMMMh`     `s   yMMMy../o`o. MMMMM:   yMMMMd   ");
            WL(" :MMMMMds/-.   `   mMMM/   `sMMMy:yNMd:`   /Mo mMMMy   Md .yMMMNNMoMMM:   `:++o+/`yMMMmyymm  ` MMMMM-  :NMMNh.   ");
            WL("  yMMMMMMMNmdy/.   mMMM/    sMMMmdMMMm:   `mMhsyMMMM-  Md  `+NMMMMoMMM-    .MMMM. yMMMy``.y`   MMMMM++hNMMh-     ");
            WL("   :hmNMMMMMMMMm:  mMMM/    sMMMo`hMMMN:  yM++sdMMMMh  Md    -dMMMoMMMo     MMMM  yMMMy   `  -.MMMMMmNMMMMN/     ");
            WL("  `  `-:+ydNMMMMm  mMMM/    sMMMo `hMMMN.:Mh   `oMMMM: Md     `sMM-mMMN:    MMMM  yMMMh    `/y`MMMMM:-dMMMMMo    ");
            WL("  h-      `/MMMMN .NMMMs`  `hMMMy` .NMMMdmM/    .NMMMm-Mm`     .MM..smMNy+/yMMMM.`hMMMNo:/odN:`MMMMM- .dMMMMM+   ");
            WL("  Mm:`     +MMMN+`/+++++:  -+++++- -+++++++/    :+++++/++-     /++/  `-/++++++++:-+++++++++oo `MMMMM-  .mMMMMN-  ");
            WL(" -MMMdyooshNMNh:    ```````````                                         ````                  -MMMMM/   /MMMMMd. ");
            WL(" .//+osyyyso/.     .mdhdddddhdm-+oooo/``/oooo+`:ooooo--+ooooo+ .+o+../yhddhhhyh-    -+yhhyoo:-syyyyys: `oyyyyyyo-");
            WL(" `---------------- oh/-hMMMs-/d+/MMMM.  .MMMM/ `dMMMy  hMNMMMm. oMo/mMMNo-.-:sN+  .hNMN+:/sNy`------------------.");
            WL(" -ssssssssssssssso +`  yMMMo  `+-MMMN////MMMM-  hMMMs  sM+dMMMm/+M/mMMM/      -+  yMMMm.`  .s-ssssssssssssssssss:");
            WL("                       yMMMo    -MMMM++++MMMM-  hMMMs  sM-`oNMMMdM/NMMm    .+ooo+:sMMMMNdyo:.                    ");
            WL("                       yMMMo    -MMMN    MMMM-  hMMMs  sM-  :dMMMM/NMMd     oMMMh``odNMMMMMMmo                   ");
            WL("                       yMMMo    -MMMN    MMMM-  hMMMs  sM-   `sNMM/mMMM.    /MMMs-:  .:+yNMMMM-                  ");
            WL("                       yMMMs    -MMMN    MMMM-  hMMMs  sM-     /NM/oNMMd.   +MMMs.m-     +MMMN.                  ");
            WL("                      .dMMMh.   +MMMM.  -MMMM/ `dMMMy``hM:     `hMo`:hNMms++mMMMy`NNho//omMNd:                   ");
            WL("                     `://///:  `/++++/ `/++++/`:+++++.-++/`    .+++.  .:/++++++++./+osyyyo/-                     ");
            WL(" -oooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo`");
            N(); S(750); N(); S(750); N(); S(750); N(); S(750); N(); S(750); N(); S(750); N(); S(500); N(); S(500); N(); S(500); N(); S(250); N(); S(250); N(); S(250); N(); S(250); N(); S(250); N(); S(250); N(); C(); S(3000);
        }
    }
}