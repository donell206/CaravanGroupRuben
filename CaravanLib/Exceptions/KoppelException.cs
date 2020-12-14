using System;

namespace CaravanLib.Exceptions
{
    public class KoppelException : Exception
    {
        #region PROPERTIES
        public int Snelheid { get; set; }
        #endregion
        #region CONSTRUCTORS
        public KoppelException(string message, int snelheid)
        {
            Snelheid = snelheid;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Geeft error wanneer koppeling niet mogelijk is(voertuig in beweging)
        /// </summary>
        /// <returns>formatted class</returns>
        public override string Message
        {
            get
            {
                return $"Auto is nog in beweging snelheid: {Snelheid}";
            }
        }
        #endregion
    }
}
