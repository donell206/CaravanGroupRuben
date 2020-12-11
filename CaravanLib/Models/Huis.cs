using CaravanLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanLib.Models
{
    public class Huis : IBewoonbaar
    {
        #region PROPERTIES
        private int _aantalSlaapkamers;

        public virtual int AantalSlaapkamers
        {
            get { return _aantalSlaapkamers; }
            set { _aantalSlaapkamers = value; }
        }

        private int _bewoonbaarOppervlakte;

        public int BewoonbaarOppervlakte
        {
            get { return _bewoonbaarOppervlakte; }
            set 
            { 
                _bewoonbaarOppervlakte = value; 
            }
        }

        #endregion
        #region CONSTRUCTORS
        public Huis(int aantalSlaapkamers, int bewoonbaarOppervlakte)
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public SetAantalSlaapkamers(IBewoonbaar)
        {
            if (AantalSlaapkamers <= 0)
            {
                Console.WriteLine("Deze waarde moet groter zijn dan 0.");
            }
            else
            {
                AantalSlaapkamers = aantalSlaapkamers;
            }
        }
        public void SetBewoonbaarOppervlakte(IBewoonbaar)
        {
                if (BewoonbaarOppervlakte <= 0)
                {
                    Console.WriteLine("Deze waarde moet groter zijn dan 0.");
                }
                else
                {
                    BewoonbaarOppervlakte = bewoonbaarOppervlakte;
                }
         }
        

        public override string ToString()
        {
            return base.ToString() + $"\nAantal slaapkamers: {AantalSlaapKamers}\nOppervlakte: {BewoonbaarOppervlakte}"; ;
        }
        #endregion
    }
}
