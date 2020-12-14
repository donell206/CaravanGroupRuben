namespace CaravanLib.Interfaces
{
    public interface ITrekker : ITrekbaar
    {
        #region PROPERTIES
        ITrekbaar AanhangWagen { get; }
        int MaximaalTrekGewicht { get; }
        #endregion
        #region METHODS
        //Koppelt de aanhangwagen
        void KoppelAanhangwagen(ITrekbaar aanhangwagen);
        #endregion
    }
}
