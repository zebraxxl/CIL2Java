using System;
using System.Collections.Generic;
using System.Globalization;

namespace CIL2Java.Globalization
{
    internal class InvariantCultureInfo : CultureInfo
    {
        private Calendar calendar = new GregorianCalendar();
        private Calendar[] optionalCalendars;

        public InvariantCultureInfo()
            : base(127)
        {
            optionalCalendars = new Calendar[] { calendar };
        }

        public override Calendar Calendar
        {
            get
            {
                return new GregorianCalendar();
            }
        }

        public override string DisplayName
        {
            get
            {
                return "Invariant Language (Invariant Country)";
            }
        }

        public override string EnglishName
        {
            get
            {
                return "Invariant Language (Invariant Country)";
            }
        }

        public override bool IsNeutralCulture
        {
            get
            {
                return false;
            }
        }

        public override int KeyboardLayoutId
        {
            get
            {
                return 127;
            }
        }

        public override int LCID
        {
            get
            {
                return 127;
            }
        }

        public override string Name
        {
            get
            {
                return "";
            }
        }

        public override string NativeName
        {
            get
            {
                return "Invariant Language (Invariant Country)";
            }
        }

        public override Calendar[] OptionalCalendars
        {
            get
            {
                return optionalCalendars;
            }
        }

        public override CultureInfo Parent
        {
            get
            {
                return this;
            }
        }

        public override string ThreeLetterISOLanguageName
        {
            get
            {
                return "ivl";
            }
        }

        public override string ThreeLetterWindowsLanguageName
        {
            get
            {
                return "IVL";
            }
        }

        public override string TwoLetterISOLanguageName
        {
            get
            {
                return "iv";
            }
        }
    }
}
