using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayers.Business
{
    public class theme
    {
            #region Attributs
            private int _id;
            private string _theme;
            #endregion

            #region Constructeurs
            public theme(int id, string theme)
            {
                _id = id;
                _theme = theme;
            }

            public theme()
            {
                _id = -1;
                _theme = "";
            }
            #endregion

            #region Accesseurs
            public int IdTheme { get => _id; set => _id = value; }
            public string Theme { get => _theme; set => _theme = value; }
        #endregion
    }
}
