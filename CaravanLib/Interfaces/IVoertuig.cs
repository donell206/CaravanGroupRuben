namespace CaravanLib.Interfaces
{
    public interface IVoertuig
    {
        #region PROPERTIES
        int MaximumSnelheid { get; }
        string Merk { get; }
        int Snelheid { get; }
        #endregion
        #region METHODS
        // Versnel van het voertuig.
        void Versnel(int versnelling);
        // Vertraag van het voertuig.
        void Vertraag(int vertraging);
        #endregion
    }
}
