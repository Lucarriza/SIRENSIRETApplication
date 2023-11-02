using Microsoft.AspNetCore.Mvc;
using SIRENSIRETApplication.Shared.Models;

namespace SIRENSIRETApplication.Server.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public ClientsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        [Route("api/saisies")]
        public List<Saisie> GetAll()
        {
            return _dataAccessProvider.GetAllSaisies();
        }

        [HttpGet]
        [Route("api/saisie/{id}")]
        public Saisie Get(int id)
        {
            return _dataAccessProvider.GetSaisie(id);
        }

        [HttpPost]
        [Route("api/saisie")]
        public void Create([FromBody] Saisie saisie)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.AddSaisie(saisie);
            }
        }

        [HttpPut]
        [Route("api/saisie/{id}")]
        public void Edit([FromBody] Saisie saisie)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateSaisie(saisie);
            }
        }

        [HttpDelete]
        [Route("api/saisie/{id}")]
        public void DeleteConfirmed(int id)
        {
            _dataAccessProvider.DeleteSaisie(id);
        }
    }
}