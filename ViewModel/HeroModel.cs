using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1.ViewModel
{
    public class HeroModel : Notifier
    {
        private string realName, heroName;

        public string RealName
        {
            get => realName;
            set => SetAndNotify(ref realName, value, nameof(RealName));
        }
        public string HeroName
        {
            get => heroName;
            set => SetAndNotify(ref heroName, value, nameof(HeroName));
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", heroName, realName);
        }
    }
}
