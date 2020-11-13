using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayers;
using ModelLayers.Data;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            dbal BDD = new dbal();

            DAOsalles salles = new DAOsalles(BDD);
            DAOavis avis = new DAOavis(BDD, salles);
            DAOtheme theme = new DAOtheme(BDD);
        }
    }
}
