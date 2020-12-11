using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanLib.Interfaces
{
    public interface ITrekker : ITrekbaar
    {
        #region PROPERTIES
        ITrekbaar AanhangWagen { get; }
        int MaximaalTrekGewicht { get; }
        #endregion
        #region METHODS
        void KoppelAanhangwagen(ITrekbaar aanhangwagen);
        #endregion
    }
}
