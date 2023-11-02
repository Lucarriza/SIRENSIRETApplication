using SIRENSIRETApplication.Server.DataAccess;
using SIRENSIRETApplication.Shared.Models;

public class DataAccessSqlProvider : IDataAccessProvider
{
    private readonly DomainModelSqlContext _context;

    public DataAccessSqlProvider(DomainModelSqlContext context)
    {
        _context = context;
    }

    public void AddSaisie(Saisie saisie)
    {
        _context.saisie.Add(saisie);
        _context.SaveChanges();
    }

    public void UpdateSaisie(Saisie saisie)
    {
        _context.saisie.Update(saisie);
        _context.SaveChanges();
    }

    public void DeleteSaisie(int id)
    {
        var entity = _context.saisie.First(t => t.id == id);
        _context.saisie.Remove(entity);
        _context.SaveChanges();
    }

    public Saisie GetSaisie(int id)
    {
        return _context.saisie.First(t => t.id == id);
    }

    public List<Saisie> GetAllSaisies()
    {
        return _context.saisie.ToList();

    }
}