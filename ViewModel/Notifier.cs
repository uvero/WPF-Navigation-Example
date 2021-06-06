using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp1.ViewModel
{
   public  class Notifier
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        protected void SetAndNotify<T>(ref T variable, T value, string propertyName, params string[] additionalProperties)
        {
            variable = value;
            Notify(propertyName);
            if (additionalProperties != null && additionalProperties.Length >= 0)
            {
                foreach (var additionalProperty in additionalProperties)
                {
                    Notify(additionalProperty);
                }
            }
        }
    }
}
