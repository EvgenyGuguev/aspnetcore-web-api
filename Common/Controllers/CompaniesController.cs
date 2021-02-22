using System;
using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Common.Controllers
{
    [ApiController]
    [Route("api/companies")]
    public class CompaniesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public CompaniesController(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCompanies()
        {
            try
            {
                var companies = _repository.Company.GetAllCompanies(false);
                return Ok(companies);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCompanies)} action {e}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}