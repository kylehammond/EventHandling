using System;
using StrangerEventsTesting.Crying;

namespace StrangerEventsTesting.Characters
{
    public class Cryer : Character
    {
        public Cryer(string name) : base(name) { }

        public event EventHandler<CryEventArgs> CriedWithChristmasLights;
        public event EventHandler<CryEventArgs> CriedIntoExplodingPhone;
        public event EventHandler<CryEventArgs> CriedFromTheUpsideDown;
        public event EventHandler<CryEventArgs> CriedToWalkieTalkie;
        public event EventHandler<CryEventArgs> CriedFromSideOfPool;

        public int ChristmasLightListenerCount => CriedWithChristmasLights?.GetInvocationList().Length ?? 0;
        public int ExplodingPhoneListenerCount => CriedIntoExplodingPhone?.GetInvocationList().Length ?? 0;
        public int UpsideDownListenerCount => CriedFromTheUpsideDown?.GetInvocationList().Length ?? 0;
        public int WalkieTalkieListenerCount => CriedToWalkieTalkie?.GetInvocationList().Length ?? 0;
        public int SideOfPoolListenerCount => CriedFromSideOfPool?.GetInvocationList().Length ?? 0;
        public int TotalListeners => ChristmasLightListenerCount + ExplodingPhoneListenerCount + UpsideDownListenerCount + WalkieTalkieListenerCount + SideOfPoolListenerCount;

        public void CryForHelp(string helpMessage, CryType cryType)
        {
            Disp.WL(Name + " cried for help from " + new CryTypeText()[cryType] + "!  The message was: " + helpMessage + "!");
            Disp.S(5000);
            Disp.N();

            OnCriedForHelp(helpMessage, cryType);

            Disp.S(7000);
            Disp.N();
            Disp.N();
        }

        protected virtual void OnCriedForHelp(string helpMessage, CryType cryType)
        {
            var cryEventArgs = new CryEventArgs { CrierName = Name, CryType = cryType, HelpMessage = helpMessage };

            if (TotalListeners > 0)
            {
                switch (cryType)
                {
                    case CryType.Walkie:
                        CriedToWalkieTalkie?.Invoke(this, cryEventArgs);
                        break;
                    case CryType.SideOfPool:
                        CriedFromSideOfPool?.Invoke(this, cryEventArgs);
                        break;
                    case CryType.ChristmasLights:
                        CriedWithChristmasLights?.Invoke(this, cryEventArgs);
                        break;
                    case CryType.ExplodingPhone:
                        CriedIntoExplodingPhone?.Invoke(this, cryEventArgs);
                        break;
                    case CryType.UpsideDown:
                        CriedFromTheUpsideDown?.Invoke(this, cryEventArgs);
                        break;
                }
            }
            else { Disp.A(); Disp.WL("No one listened..."); }
        }
    }
}