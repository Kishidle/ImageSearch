using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPagePractice
{
    public class Class1: INotifyPropertyChanged
    {
        public int SwitchView
        {
            get;
            set;

        }

        public Class1()
        {
            SwitchView = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyRaised(string propertyname)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        
    }
}
