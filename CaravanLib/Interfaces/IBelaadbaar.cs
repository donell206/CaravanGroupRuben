namespace CaravanLib.Interfaces
{
    public interface IBelaadbaar
    {
        #region PROPERTIES
        int HuidigeBelading{ get; }
        int MaximumLaadgewicht { get; }
        #endregion

        #region METHODS
        /// <summary>
        /// Laden(toename gewicht) Lossen(afname gewicht)
        /// </summary>
        /// <param name="gewicht"></param>
        void Laden(int gewicht);
        void Lossen(int gewicht);   
        #endregion
    }
}
