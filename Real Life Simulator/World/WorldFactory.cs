using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Life_Simulator
{
    public static class WorldFactory
    {
        //Project Folder inside \bin\Debug\
        public static string ProjectPath = Path.Combine(System.Windows.Forms.Application.StartupPath);
        //Main Project Folder (without \bin\Debug\)
        public static string ProjectPathTrimmed = GetProjectPath();
        //Main Project Folder but inside Locations Folder
        public static string LocationsPath = ProjectPathTrimmed + @"Resources\Images\Locations\";

        //Method to trim the Main Folder with \bin\Debug\ to WITHOUT \bin\Debug\
        public static string GetProjectPath()
        {
            return ProjectPath.Remove(ProjectPath.Length - 9);
        }

        //World Location Creator with X and Y Coordinates
        internal static World CreateWorld()
        {
            World newWorld = new World();
            //                   X, Y

            for (int x = -100; x < 100; x++)
            {
                for (int y = -100; y < 100; y++)
                {
                    newWorld.AddLocation(x, y, "Straße", "Straße", LocationsPath + "Straße.jpg");

                    newWorld.AddLocation(-4, -2, "Bäckerei", "Die besten Brötchen nur beim Bäcker",
                        LocationsPath + "Bäckerei.jpg");
                    // Y plus (nach oben)




                    // Y minus (nach unten)
                    newWorld.AddLocation(-7, 0, "Ubahn", "Ubahn Station",
                        LocationsPath + "Ubahn.jpg");





                    // ZENTRALPUNKT X = 0, Y = 0
                    newWorld.AddLocation(0, 0, "Zentralpunkt Wien", "Zentralpunkt von Wien im 1.Bezirk",
                        LocationsPath + "ZentralpunktWien.jpeg");





                    // X plus (nach rechts)
                    newWorld.AddLocation(3, -1, "Rathaus Wien", "Rathaus",
                        LocationsPath + "Rathaus.jpg");






                    // X minus (nach links)

                }
            }


            


            return newWorld;
        }
    }
}
