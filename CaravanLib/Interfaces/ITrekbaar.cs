using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanLib.Interfaces
{
    public interface ITrekbaar
    {
        #region PROPERTIES
        int AantalBanden { get; }
        int Gewicht { get; }
        #endregion
    }
}
