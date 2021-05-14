﻿using System.ComponentModel;

namespace Demo
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        public event PropertyChangedEventHandler PropertyChanged;

        public Person()
        {
        }

        public Person(string value)
        {
            this.name = value;
        }

        public string PersonName
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("PersonName");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
