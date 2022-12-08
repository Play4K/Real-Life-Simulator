using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public class Player : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullname;
        private string _gender;
        private string _job;
        private int _age;
        private double _health;
        private double _hunger;
        private double _thirst;
        private double _energy;
        private double _exhaustion;
        private double _balance;

        public List<Diseases> PlayerDiseases = new List<Diseases>();
        private SQLConnection sqlConnection = new SQLConnection();


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
                if (value != _fullname)
                    _fullname = value;
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

        public string Job
        {
            get { return _job; }
            set
            {
                if (value != _job)
                    _job = value;
                OnPropertyChanged("Job");
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

        public double Health
        {
            get { return _health; }
            set
            {
                if (value != _health)
                    _health = value;
                OnPropertyChanged("Health");
            }
        }
        public double Hunger
        {
            get { return _hunger; }
            set 
            { 
                if (value != _hunger)
                    _hunger = value;
                OnPropertyChanged("Hunger");
            }
        }
        public double Thirst
        {
            get { return _thirst; }
            set 
            { 
                if (value != _thirst)
                    _thirst = value;
                OnPropertyChanged("Thirst");
            }
        }

        public double Energy
        {
            get { return _energy; }
            set 
            { 
                if (value != _energy)
                    _energy = value;
                OnPropertyChanged("Energy");
            }
        }

        public double Exhaustion
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

        public void Sleep(int hours)
        {
            //Body gains 10 Energy for 1 hour sleep
            MessageBox.Show("Player slept");
            Energy += (hours * 10);
        }

        

        //public double BodyGetsTiredNaturally(double seconds)
        //{
        //    SQLConnection sqlConnection = new SQLConnection();
        //    sqlConnection.con.Open();
        //    sqlConnection.cmd = new MySqlCommand("SELECT * FROM tbl_players WHERE AccountID='" + GameSession.connectedAccountID + "' AND Id='" + GameSession.choosenPlayerID + "'", sqlConnection.con);
        //    sqlConnection.sqlDataReader = sqlConnection.cmd.ExecuteReader();
        //    if (sqlConnection.sqlDataReader.Read())
        //    {
        //        GameSession.gameSession.currentPlayer.Energy = Convert.ToDouble(sqlConnection.sqlDataReader["Energy"]);
        //        sqlConnection.sqlDataReader.Close();
        //    }
        //    sqlConnection.con.Close();

        //    SQLConnection sqlConnection2 = new SQLConnection();

        //    sqlConnection2.con.Open();
        //    sqlConnection2.cmd = new MySqlCommand("UPDATE tbl_players SET Energy='" + GameSession.gameSession.currentPlayer.Energy + "' WHERE AccountID='" + GameSession.connectedAccountID + "' AND Id='" + GameSession.choosenPlayerID + "'", sqlConnection2.con);
        //    sqlConnection2.cmd.Parameters.AddWithValue("@Energy", GameSession.gameSession.currentPlayer.Energy);
        //    sqlConnection2.cmd.ExecuteNonQuery();
        //    sqlConnection2.con.Close();

        //    return GameSession.gameSession.currentPlayer.Energy -= seconds;

        //}
    }
}
