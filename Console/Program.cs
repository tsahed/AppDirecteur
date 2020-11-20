using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayers;
using ModelLayers.Data;
using ModelLayers.Business;

namespace Console
{
    class Program
    {
        private static dbal dbal;
        private static DAOsalles salles;
        private static DAOavis avis;
        private static DAOtheme theme;

        static void Main(string[] args)
        {
            dbal = new dbal("LSRGames");
            salles = new DAOsalles(dbal);
            avis = new DAOavis();
            theme = new DAOtheme(dbal);

            //Fait -> salles.InsertFromCSV("D:\\Thalia\\PPE\\AppDirecteur\\AppDirecteur\\ModelLayers\\Fichiers_Csv\\salles.csv");
            avis.InsertFromCSV("D:\\Thalia\\PPE\\AppDirecteur\\AppDirecteur\\ModelLayers\\Fichiers_Csv\\avis.csv");
            //Fait -> theme.InsertFromCSV("D:\\Thalia\\PPE\\AppDirecteur\\AppDirecteur\\ModelLayers\\Fichiers_Csv\\theme.csv");

            System.Console.WriteLine("Fin");
        }
    }
}
