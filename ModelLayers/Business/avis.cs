using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayers.Business
{
    class avis
    {
        #region Attributs
        private int _idAvis;
        private int _idClient;
        private int _idSalle;
        private string _avis;
        #endregion

        #region Constructeurs
        public avis(int idAvis, int idClient, int idSalle, string avis)
        {
            _idAvis = idAvis;
            _idClient = idClient;
            _idSalle = idSalle;
            _avis = avis;
        }

        public avis()
        {
            _idAvis = -1;
            _idClient = -1;
            _idSalle = -1;
            _avis = "";
        }
        #endregion

        #region Accesseurs
        public int IdAvis { get => _idAvis; set => _idAvis = value; }
        public int IdClient { get => _idClient; set => _idClient = value; }
        public int IdSalle { get => _idSalle; set => _idSalle = value; }
        public string Avis1 { get => _avis; set => _avis = value; }
        #endregion
    }
}
