using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Common.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/{v:apiversion}/companies")]
    [ApiController]
    public class CompaniesV2Controller : ControllerBase
    {
        private readonly IRepositoryManager _repository;

        public CompaniesV2Controller(IRepositoryManager repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _repository.Company.GetAllCompaniesAsync( false);

            return Ok(companies);
        }
    }
}