using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Real_Life_Simulator
{
    public partial class WorldCtrl : UserControl, INotifyPropertyChanged
    {
        GameSession gameSession;

        const int GridWidth = 5000;
        const int GridHeight = 5000;

        //destinationChosen wurde deklariert und im Code verwendet, da zum Start des Programmes playerPosition und destionationPosition
        //auf dem selben Point sind und das playerPoint über dem destinationPoint steht und gesehen wird
        private bool destinationChosen = false;
        private static Point playerPosition = new Point(40, 40);
        private Point destinationPosition = new Point(playerPosition.X, playerPosition.Y);
        private static List<Point> pointList = new List<Point>();

        private int onePointInMeter = 10;
        private int calculatedRouteSeconds = 10;
        private double playerSpeed = 1.0;   //Meters in second

        private double calculatedX = 0;
        private double calculatedY = 0;

        public List<PointCoordinate> Coordinates = new List<PointCoordinate>()
        {
            new PointCoordinate() { Name = "First Appartment", Point = new Point(40, 40) },
            new PointCoordinate() { Name = "BILLA", Point = new Point(20, 20) },
            new PointCoordinate() { Name = "Apotheke", Point = new Point(25, 40) },
            new PointCoordinate() { Name = "Krankenhaus", Point = new Point(40, 10) },
            new PointCoordinate() { Name = "Werkstatt", Point = new Point(34, 22) },
            new PointCoordinate() { Name = "Microsoft", Point = new Point(30, 40) },
            new PointCoordinate() { Name = "Kleidungsgeschäft", Point = new Point(40, 35) },
            new PointCoordinate() { Name = "Mediamarkt", Point = new Point(50, 30) },
            new PointCoordinate() { Name = "Rathaus", Point = new Point(50, 40) },
        };

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public WorldCtrl()
        {

            InitializeComponent();

            PrintCoordinatesToPointList();
            PrintCoordinatesToListBox();

            Pbx_Coordinate.Size = new System.Drawing.Size(GridWidth, GridHeight);
        }

        private void WorldCtrl_Load(object sender, EventArgs e)
        {
            
        }


        private void PrintCoordinatesToListBox()
        {
            Lbx_Coordinates.Items.Clear();
            foreach (var coordinate in pointList)
            {
                Lbx_Coordinates.Items.Add($"X = {coordinate.X}, Y = {coordinate.Y}");
            }
        }

        public void PrintCoordinatesToPointList()
        {
            foreach (var point in Coordinates)
            {
                pointList.Add(new Point(point.Point.X, point.Point.Y));
            }
        }

        private void Pbx_Coordinate_Paint(object sender, PaintEventArgs e)
        {
            // Simple drawing, just draw a grid, and the points
            e.Graphics.Clear(Color.White);

            for (int x = 0; x < GridWidth; x++)
            {
                e.Graphics.DrawLine(Pens.Black, x * 20 + 10, 0, x * 20 + 10, Pbx_Coordinate.Height);
            }

            for (int y = 0; y < GridHeight; y++)
            {
                e.Graphics.DrawLine(Pens.Black, 0, y * 20 + 10, Pbx_Coordinate.Width, y * 20 + 10);
            }

            foreach (var pt in pointList)
            {
                e.Graphics.FillRectangle(Brushes.Black, (pt.X * 20 + 10) - 8, (pt.Y * 20 + 10) - 8, 16, 16);
            }

            //Print Player Position
            PrintPlayerPosition(sender, e);

            //Print Destination Position
            PrintDestinationPosition(sender, e);

            //Calculate the distance between Player and Destination Position
            CalculateRoute(sender, e);
        }

        private void Btn_Supermarket_Click(object sender, EventArgs e)
        {
            SupermarketCtrl supermarket = new SupermarketCtrl();
            Main.mainInstance.PanelContainer.Controls.Clear();
            Main.mainInstance.PanelContainer.Controls.Add(supermarket);
        }

        void Pbx_Coordinate_MouseUp_AddDestination(object sender, MouseEventArgs e)
        {
            //Wenn die Taste gedrückt wird dann..
            //if (ModifierKeys.HasFlag(Keys.Control))
            //{

            //}

            int x = (int)Math.Round((((double)e.X) - 10.0) / 20.0, 0);
            int y = (int)Math.Round((((double)e.Y) - 10.0) / 20.0, 0);
            destinationPosition.X = x;
            destinationPosition.Y = y;

            //If Location MATCHES with Location from Coordinates List
            foreach (var point in Coordinates)
            {
                if (point.Point.X.Equals(x) && point.Point.Y.Equals(y))
                {
                    if (point.Name == "First Appartment")
                    {
                        Hide();
                        FirstApparment firstApparment = new FirstApparment();
                        Main.mainInstance.PanelContainer.Controls.Clear();
                        Main.mainInstance.PanelContainer.Controls.Add(firstApparment);
                    }
                    else if (point.Name == "BILLA")
                    {
                        Hide();
                        BillaCtrl billa = new BillaCtrl();
                        Main.mainInstance.PanelContainer.Controls.Clear();
                        Main.mainInstance.PanelContainer.Controls.Add(billa);
                    }
                    if (point.Name == "Apotheke")
                    {
                        Hide();
                        ApothekeCtrl apotheke = new ApothekeCtrl();
                        Main.mainInstance.PanelContainer.Controls.Clear();
                        Main.mainInstance.PanelContainer.Controls.Add(apotheke);
                    }
                    if (point.Name == "Krankenhaus")
                    {
                        Hide();
                        KrankenhausCtrl krankenhaus = new KrankenhausCtrl();
                        Main.mainInstance.PanelContainer.Controls.Clear();
                        Main.mainInstance.PanelContainer.Controls.Add(krankenhaus);
                    }
                    if (point.Name == "Kleidungsgeschäft")
                    {
                        Hide();
                        Kleidungsgeschäft kleidungsgeschäft = new Kleidungsgeschäft();
                        Main.mainInstance.PanelContainer.Controls.Clear();
                        Main.mainInstance.PanelContainer.Controls.Add(kleidungsgeschäft);
                    }
                    if (point.Name == "Mediamarkt")
                    {
                        Hide();
                        MediamarktCtrl mediamarkt = new MediamarktCtrl();
                        Main.mainInstance.PanelContainer.Controls.Clear();
                        Main.mainInstance.PanelContainer.Controls.Add(mediamarkt);
                    } 
                    else
                    {
                        
                    }
                }
            }

            destinationChosen = true;
            PrintCoordinatesToListBox();

            double calculatedXInMeters = calculatedX * onePointInMeter;
            double calculatedYInMeters = calculatedY * onePointInMeter;
            double totalInMeters = calculatedXInMeters + calculatedYInMeters;
            Txt_DistanceInMeters.Text = $"{totalInMeters}m";

            

            //Point selectedPoint = new Point(x, y);

            ////If selectedPoint matches Location of pointList
            //foreach (var point in pointList)
            //{
            //    if (selectedPoint.Equals(point))
            //    {
            //        calculatedXInMeters = calculatedX * onePointInMeter;
            //        calculatedYInMeters = calculatedY * onePointInMeter;
            //        totalInMeters = calculatedXInMeters + calculatedYInMeters;

            //        Txt_DistanceInMeters.Text = $"{totalInMeters}m";
            //    }
            //}
        }

        public void LocationMatches(Point matchedPoint)
        {
            foreach (PointCoordinate point in Coordinates)
            {
                
                
            }
        }

        private void CalculateRoute(object sender, PaintEventArgs e)
        {
            calculatedX = destinationPosition.X - playerPosition.X;
            calculatedY = destinationPosition.Y - playerPosition.Y;
            Txt_DistanceCalculation.Text = $"X = {calculatedX}, Y = {calculatedY}";

            //Kalkurierender Weg der auf der X Achse nach "rechts" Points einzeichnet
            //playerPosition.X + 1 = die 1 steht dafür dass die Points nach 1 Point Abstand (da sonst vom Point playerPosition schon eingezeichnet wird)
            for (int i = playerPosition.X + 1; i <= destinationPosition.X - 1; i++)
            {
                e.Graphics.FillRectangle(Brushes.DarkGoldenrod, (i * 20 + 10) - 8, (playerPosition.Y * 20 + 10) - 8, 16, 16);
            }
            //Kalkurierender Weg der auf der X Achse nach "links" Points einzeichnet
            //playerPosition.X + 1 = die 1 steht dafür dass die Points nach 1 Point Abstand (da sonst vom Point playerPosition schon eingezeichnet wird)
            for (int i = playerPosition.X - 1; i >= destinationPosition.X + 1; i--)
            {
                e.Graphics.FillRectangle(Brushes.DarkGoldenrod, (i * 20 + 10) - 8, (playerPosition.Y * 20 + 10) - 8, 16, 16);
            }

            //Wenn die X Achse vom playerPosition und destinationPosition auf der selben Achse sind,
            //soll die Y Achse auf 2 Arten berechnet werden (wegen dem Y +/- auf dem Mittelpunkt des playerPosition.X)
            if (playerPosition.X == destinationPosition.X)
            {
                //Kalkurierender Weg der auf der Y Achse nach "unten" Points einzeichnet
                //playerPosition.Y + 1 = die 1 steht dafür dass die Points nach 1 Point Abstand (da sonst vom Point playerPosition schon eingezeichnet wird)
                for (int j = playerPosition.Y + 1; j < destinationPosition.Y; j++)
                {
                    e.Graphics.FillRectangle(Brushes.DarkGoldenrod, (destinationPosition.X * 20 + 10) - 8, (j * 20 + 10) - 8, 16, 16);
                }
                //Kalkurierender Weg der auf der Y Achse nach "oben" Points einzeichnet
                //playerPosition.Y + 1 = die 1 steht dafür dass die Points nach 1 Point Abstand (da sonst vom Point playerPosition schon eingezeichnet wird)
                for (int j = playerPosition.Y - 1; j > destinationPosition.Y; j--)
                {
                    e.Graphics.FillRectangle(Brushes.DarkGoldenrod, (destinationPosition.X * 20 + 10) - 8, (j * 20 + 10) - 8, 16, 16);
                }
            }
            else
            {
                //Kalkurierender Weg der auf der Y Achse nach "unten" Points einzeichnet
                //playerPosition.Y steht so alleine, da die Points auf der X Achse = 0 schon eingezeichnet werden müssen
                for (int j = playerPosition.Y; j < destinationPosition.Y; j++)
                {
                    e.Graphics.FillRectangle(Brushes.DarkGoldenrod, (destinationPosition.X * 20 + 10) - 8, (j * 20 + 10) - 8, 16, 16);
                }
                //Kalkurierender Weg der auf der Y Achse nach "oben" Points einzeichnet
                //playerPosition.Y steht so alleine, da die Points auf der X Achse = 0 schon eingezeichnet werden müssen
                for (int j = playerPosition.Y; j > destinationPosition.Y; j--)
                {
                    e.Graphics.FillRectangle(Brushes.DarkGoldenrod, (destinationPosition.X * 20 + 10) - 8, (j * 20 + 10) - 8, 16, 16);
                }
            }
        }

        public void PrintPlayerPosition(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.DodgerBlue, (playerPosition.X * 20 + 10) - 8, (playerPosition.Y * 20 + 10) - 8, 16, 16);
            Txt_PlayerPosition.Text = $"X = {playerPosition.X}, Y = {playerPosition.Y}";
        }

        public void PrintDestinationPosition(object sender, PaintEventArgs e)
        {
            if (destinationChosen)
            {
                e.Graphics.FillRectangle(Brushes.Green, (destinationPosition.X * 20 + 10) - 8, (destinationPosition.Y * 20 + 10) - 8, 16, 16);
                Txt_DestinationPosition.Text = $"X = {destinationPosition.X}, Y = {destinationPosition.Y}";
            }
        }

        private void Pbx_Coordinate_MouseUp(object sender, MouseEventArgs e)
        {
            Pbx_Coordinate_MouseUp_AddDestination(sender, e);
            Pbx_Coordinate.Invalidate();
        }

        private TextBox text = new TextBox();
        private DateTime endTime;
        private void Pbx_Coordinate_MouseMove(object sender, MouseEventArgs e)
        {
            int x = (int)Math.Round((((double)e.X) - 10.0) / 20.0, 0);
            int y = (int)Math.Round((((double)e.Y) - 10.0) / 20.0, 0);

            foreach (PointCoordinate point in Coordinates)
            {
                if (x.Equals(point.Point.X) && y.Equals(point.Point.Y))
                {
                    text.Text = point.Name;
                    text.Font = new Font("Arial", 12, FontStyle.Bold);
                    text.ForeColor = Color.DodgerBlue;
                    text.Location = new Point(e.X - 20, e.Y - 50);
                    text.Size = new Size(150, 22);
                    Form.ActiveForm.Controls.Add(text);
                    //Bring to Front muss nachdem es geaddet wurde (in Controls) geschrieben werden
                    text.BringToFront();
                }
                //if ((x + 5) > point.Point.X || (x - 5) < point.Point.X || (y + 5) > point.Point.Y || (y - 5) < point.Point.Y)
                //{
                //    Form.ActiveForm.Controls.Remove(text);
                //    count = 0;
                //    Lbl_Count.Text = "Count: " + count.ToString();
            }
        }

        public void Start()
        {
            var start = DateTime.UtcNow;
            endTime = start.AddSeconds(calculatedRouteSeconds);
            Tmr_Route.Enabled = true;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void Tmr_Route_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                Tmr_Route.Enabled = false;
                Tmr_Route.Stop();
            }
            else
            {
                Txt_RemaningTime.Text = remainingTime.ToString(@"hh\:mm\:ss");
            }
        }

    }
}
