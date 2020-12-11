using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Motorhome : Auto, IBewoonbaar
    {
        public int AantalSlaapKamers { get; private set; }
        private int _bewoonbaarOppervlakte;

        public int BewoonbaarOppervlakte
        {
            get { return _bewoonbaarOppervlakte; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Het bewoonbare oppervlakte mag niet kleiner dan 0 zijn");
                }
                else
                {
                    _bewoonbaarOppervlakte = value;
                }
            }
        }

        #region PROPERTIES
        public Motorhome()
        {
            AantalSlaapKamers = 1;
        }
        public Motorhome(int bewoonbaarOppervlakte) : this()
        {

        }
        #endregion
        #region CONSTRUCTORS

        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
