using System;
using System.Linq;
using Contracts;
using Entities.DataTransferObjects;
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
                var companiesDto = companies.Select(c => new CompanyDto
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullAddress = $"{c.Address} {c.Country}"
                }).ToList();
                return Ok(companiesDto);
            }
            catch (Exception e)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetCompanies)} action {e}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}