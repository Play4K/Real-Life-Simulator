using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Life_Simulator
{
    class Player : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullname;
        private string _gender;
        private int _age;
        private int _health;
        private int _hunger;
        private int _thirst;
        private int _energy;
        private int _exhaustion;
        private double _balance;
        

        public Player()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (value != _firstName)
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set 
            {
                if (value != _lastName)
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string FullName
        {
            get { return _firstName + " " + _lastName; }
            set
            {
                FullName = value;
                OnPropertyChanged("FullName");
            }
        }
        public string Gender
        {
            get { return _gender; }
            set 
            {
                if (value != _gender)
                _gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public int Age
        {
            get { return _age; }
            set 
            {
                if (value != _age)
                _age = value;
                OnPropertyChanged("Age");
            }
        }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value != _health)
                    _health = value;
                OnPropertyChanged("Health");
            }
        }
        public int Hunger
        {
            get { return _hunger; }
            set 
            { 
                if (value != _hunger)
                _hunger = value;
                OnPropertyChanged("Hunger");
            }
        }
        public int Thirst
        {
            get { return _thirst; }
            set 
            { 
                if (value != _thirst)
                _thirst = value;
                OnPropertyChanged("Thirst");
            }
        }

        public int Energy
        {
            get { return _energy; }
            set 
            { 
                if (value != _energy)
                _energy = value;
                OnPropertyChanged("Energy");
            }
        }

        public int Exhaustion
        {
            get { return _exhaustion; }
            set 
            { 
                if (value != _exhaustion)
                _exhaustion = value;
                OnPropertyChanged("Exhaustion");
            }
        }

        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value != _balance)
                    _balance = value;
                OnPropertyChanged("Balance");
            }
        }

    }
}
