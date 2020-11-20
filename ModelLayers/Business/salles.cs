using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayers.Business
{
    public class salles
    {
        #region Attributs
        private int _idSalle;
        private string _ville;
        private int _idTheme;
        #endregion

        #region Constructeurs
        public salles(int idSalle, string ville, int idTheme)
        {
            _idSalle = idSalle;
            _ville = ville;
            _idTheme = idTheme;
        }

        public salles()
        {
            _idSalle = -1;
            _ville = "";
            _idTheme = -1;
        }
        #endregion

        #region Accesseurs
        public int IdSalle { get => _idSalle; set => _idSalle = value; }
        public string Ville { get => _ville; set => _ville = value; }
        public int IdTheme { get => _idTheme; set => _idTheme = value; }
        #endregion
    }
}
