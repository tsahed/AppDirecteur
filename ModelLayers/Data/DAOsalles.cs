using ModelLayers.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelper;
using CsvHelper.Expressions;


namespace ModelLayers.Data
{
    class DAOsalles
    {
        #region Attributs
        private dbal _dbal;
        #endregion

        #region Constructeurs
        public DAOsalles(dbal dbal)
        {
            _dbal = dbal;
        }
        #endregion


        #region Autres méthodes
        public void insert(salles unesalle)
        {
            string SalleInsert;

            SalleInsert = ("salles(idSalle, ville) values(" + unesalle.IdSalle + ",'" + unesalle.Ville.Replace("'", "''") + "')");
            _dbal.Insert(SalleInsert);
        }

        public void delete(salles unesalle)
        {
            string SalleDelete;

            SalleDelete = ("salle where id ='" + unesalle.IdSalle + "'");
            _dbal.Delete(SalleDelete);
        }

        public void update(salles unesalle)
        {
            string SalleUpdate;

            SalleUpdate = ("salles set id ='" + unesalle.IdSalle + "' , nom = '" + unesalle.Ville.Replace("'", "''") + "'");
            _dbal.Update(SalleUpdate);
        }

        public void InsertFromCSV(string chemin)
        {
            using (var reader = new StreamReader(chemin))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var record = new salles();
                IEnumerable<salles> records = csv.EnumerateRecords(record);

                foreach (salles salle in records)
                {
                    insert(salle);
                }
            }
        }

        public List<salles> SelectAll()
        {
            List<salles> listSalles = new List<salles>();
            foreach (DataRow r in _dbal.SelectAll("salles").Rows)
            {
                listSalles.Add(new salles((int)r["idSalle"], (string)r["ville"]));
            }
            return listSalles;
        }

        public salles SelectByName(string salle)
        {
            DataRow r = _dbal.SelectByField("salles", "nom like '" + salle + "'").Rows[0];
            return new salles((int)r["idSalle"], (string)r["ville"]);
        }

        public salles SelectById(int idSalle)
        {
            DataRow r = _dbal.SelectById("salles", idSalle);
            return new salles((int)r["idSalle"], (string)r["ville"]);
        }
        #endregion
    }
}
