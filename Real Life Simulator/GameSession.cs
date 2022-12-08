using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public class GameSession : INotifyPropertyChanged
    {
        public Player currentPlayer;
        public static GameSession gameSession;
        private Location _currentLocation;
        private World CurrentWorld { get; set; }
        public static int connectedAccountID;
        public static int choosenPlayerID;

        // GameTime in seconds
        //private int _gameTime = 0;

        private DateTime dateTime;
        public static DateTime dateTimeInitial;
        private Stopwatch stopwatch;

        //private System.Timers.Timer gameTimer = new System.Timers.Timer(1000);

        public GameSession()
        {
            currentPlayer = new Player();
            CurrentWorld = WorldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.GetLocationAt(0, 0);
            dateTime = new DateTime(2000, 1, 1, 12, 0, 0);
            dateTimeInitial = dateTime;
            stopwatch = new Stopwatch();
            //gameTimer.Elapsed += (sender, e) => HandleGameTimer();
            //gameTimer.Start();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        CharacterMenuCtrl characterMenu = new CharacterMenuCtrl();

        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
            }
        }

        public Stopwatch Stopwatch
        {
            get { return stopwatch; }
            set
            {
                this.stopwatch = value;
            }
        }

        public DateTime DateTime
        {
            get { return this.dateTime; }
            set
            { 
                this.dateTime = value;
                OnPropertyChanged("DateTime");
            }
        }

        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }

        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }

        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }

        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }

        public void MoveWest()
        {
            if (HasLocationToWest)
            {
                CurrentLocation = CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveSouth()
        {
            if (HasLocationToSouth)
            {
                CurrentLocation = CurrentWorld.GetLocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }

    }
}
