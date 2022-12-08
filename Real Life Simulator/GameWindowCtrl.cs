using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Life_Simulator
{
    public partial class GameWindowCtrl : UserControl
    {
        // Objekte von den Fenster werden daweil mal gleich hier "erstellt", noch nicht zugewiesen
        CharacterMenuCtrl characterMenuCtrl = null;
        InventoryCtrl inventoryCtrl = null;
        

        public GameWindowCtrl()
        {
            InitializeComponent();
            GameSession.gameSession = new GameSession();
            //Start universal Game time
            Tmr_GameTime.Start();
        }

        // load charakter Menu window into Pnl_Container
        private void Btn_Character_Click(object sender, EventArgs e)
        {
            // Ins Pnl_Container soll ein bestimmtes Fenster geladen werden
            CharacterMenuCtrl characterMenuCtrl = new CharacterMenuCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(characterMenuCtrl);
        }

        private void Btn_Inventory_Click(object sender, EventArgs e)
        {
            // load specific window into Pnl_Container
            InventoryCtrl inventoryCtrl = new InventoryCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(inventoryCtrl);
        }

        private void GameWindowCtrl_Load(object sender, EventArgs e)
        {
            // load specific window into Pnl_Container
            characterMenuCtrl = new CharacterMenuCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(characterMenuCtrl);

            //Fenstergröße soll eingestellt werden, wenn GameWindow geladen wird
            Main.mainInstance.WindowsPreset();
        }

        private void Btn_Maps_Click(object sender, EventArgs e)
        {
            WorldCtrl worldCtrl = new WorldCtrl();
            Pnl_Container.Controls.Clear();
            Pnl_Container.Controls.Add(worldCtrl);
        }

        private void Tmr_GameTime_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = GameSession.gameSession.DateTime - GameSession.dateTimeInitial;
            GameSession.gameSession.DateTime = GameSession.gameSession.DateTime.AddSeconds(1);

            //if (elapsed.Seconds == 2)
            //{

            //}

            //var timer = new System.Threading.Timer(
            //    ex => GameSession.gameSession.currentPlayer.BodyGetsTiredNaturally(1),
            //    null,
            //    TimeSpan.Zero,
            //    TimeSpan.FromSeconds(1));


            //// If a certain time is reached, something should happen
            //if (GameSession.gameSession.DateTime.ToLongTimeString().Equals("12:00:15"))
            //{
            //    MessageBox.Show("15 Sekunden vergangen");
            //}

            //TimeSpan elapsed = DateTime.Now - GameSession.gameSession.DateTime;

            //If a certain time has passed, something should happen

            ////#1
            //if (elapsed.Seconds == 5)
            //{
            //    MessageBox.Show("Wenn innerhalb 60 Sekunden-Zeit die 5.te Sekunde erreicht wird egal wie viel Zeit vergangen ist\n" +
            //                    "wird dieser Code aufgerufen");
            //}

            ////#2
            //if (elapsed.TotalSeconds == 30)
            //{
            //    MessageBox.Show("Wenn seit dem Beginnstart des TimeSpan elapsed insgesamt 30 Sekunden vergangen ist, wird dieser Code 1x aufgerufen");
            //}


            // WENN EIN BESTIMMTER TAG ERREICHT WURDE
            //DateTime date = new DateTime(year, month, day);
            //if (date < DateTime.Now)
            //{
            //    // date has passed. 
            //}
            //else
            //{
            //    // the date is in the future
            //}
        }
    }

}
