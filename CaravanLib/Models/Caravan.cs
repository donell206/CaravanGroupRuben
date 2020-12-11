using CaravanLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanLib.Models
{
    public class Caravan : Aanhangwagen, IBewoonbaar
    {
        #region PROPERTIES
        public int AantalSlaapKamers { get; set; }
        public int BewoonbaarOppervlakte { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Caravan()
        {

        }
        public Caravan(int aantalSlaapkamers, int bewoonbaarOppervlakte, int aantalbanden, int gewicht):base(aantalbanden,gewicht)
        {
            AantalSlaapKamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nAantal slaapkamers: {AantalSlaapKamers}\nOppervlakte: {BewoonbaarOppervlakte}";
        }
        #endregion
    }
}
