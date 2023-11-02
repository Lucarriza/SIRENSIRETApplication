namespace SIRENSIRETApplication.Shared.Models
{
    public interface IDataAccessProvider
    {
        void AddSaisie(Saisie saisie);
        void UpdateSaisie(Saisie saisie);
        void DeleteSaisie(int id);
        Saisie GetSaisie(int id);
        List<Saisie> GetAllSaisies();
    }
}