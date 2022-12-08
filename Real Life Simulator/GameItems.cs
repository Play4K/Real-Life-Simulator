using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Life_Simulator
{
    internal class GameItems
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public string Gender { get; set; }
        public int Health { get; set; }
        public int Thirst { get; set; }
        public int Hunger { get; set; }
        public int Energy { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }


        public static List<GameItems> gameItemsList = new List<GameItems>();
    }
}
