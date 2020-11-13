using CsvHelper;
using ModelLayers.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelLayers.Data
{
        class DAOavis
        {
            #region Attributs
            private dbal _dbal;
            //private DAOclient _DAOclient;
            private DAOsalles _DAOsalles;
            #endregion

            #region Constructeur
            public void DAOAvis(dbal dbal, DAOsalles DAOsalles)
            {
                _dbal = dbal;
                //_DAOclient = DAOclient;
                _DAOsalles = DAOsalles;
            }
            #endregion

            #region Autres méthodes
            public void insert(avis unavis)
            {
                string AvisInsert;

                AvisInsert = ("avis(idAvis, idClient, idSalle, avis) values(" + unavis.IdAvis + "," + unavis.IdClient + "," + unavis.IdSalle + ",'" + unavis.Avis1.Replace("'", "''") + "')");
                _dbal.Insert(AvisInsert);
            }

            public void delete(avis unavis)
            {
                string AvisDelete;

                AvisDelete = ("avis where id ='" + unavis.IdAvis + "'");
                _dbal.Delete(AvisDelete);
            }

            public void update(avis unavis)
            {
                string AvisUpdate;

                AvisUpdate = ("avis set idAvis ='" + unavis.IdAvis + "', idClient = '" + unavis.IdClient + "', idSalle ='" + unavis.IdSalle + "', avis = '" + unavis.Avis1.Replace("'", "''") + "'");
                _dbal.Update(AvisUpdate);
            }

            public void InsertFromCSV(string chemin)
            {
                using (var reader = new StreamReader(chemin))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Configuration.Delimiter = ";";
                    csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                    var record = new avis();
                    IEnumerable<avis> records = csv.EnumerateRecords(record);

                    foreach (avis avis in records)
                    {
                        insert(avis);
                    }
                }
            }

            public List<avis> SelectAll()
            {
                List<avis> listAvis = new List<avis>();
                foreach (DataRow r in _dbal.SelectAll("avis").Rows)
                {
                    listAvis.Add(new avis((int)r["idAvis"], (int)r["idClient"], (int)r["idSalle"], (string)r["avis"]));
                }
                return listAvis;
            }

            public avis SelectByName(string avis)
            {
                DataRow r = _dbal.SelectByField("avis", "avis like '" + avis + "'").Rows[0];
                return new avis((int)r["idAvis"], (int)r["idClient"], (int)r["idSalle"], (string)r["avis"]);
            }

            public avis SelectById(int idAvis)
            {
                DataRow r = _dbal.SelectById("avis", idAvis);
                return new avis((int)r["idAvis"], (int)r["idClient"], (int)r["idSalle"], (string)r["avis"]);
            }
            #endregion
        }
    }
