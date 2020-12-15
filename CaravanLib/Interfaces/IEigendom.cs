using System;
namespace CaravanLib.Interfaces
{
    public interface IEigendom:IComparable
    {
        #region PROPERTIES
        string Eigenaar { get; }
        double Prijs { get; }
        #endregion
        #region METHODS
        /// <summary>
        /// Nieuwe prijs bepalen
        /// 
        /// Nieuwe eigenaar bepalen
        /// </summary>
        /// <param name="nieuwePrijs"></param>
        void BepaalPrijs(double nieuwePrijs);
        void VerkoopAan(string nieuweEigenaar);
        #endregion
    }
}
