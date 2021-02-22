using AutoMapper;
using Entities.DataTransferObjects;
using Entities.Models;

namespace Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Company, CompanyDto>()
                .ForMember(c => c.FullAddress,
                    opt =>
                        opt.MapFrom(x => $"{x.Address} {x.Country}"));

            CreateMap<Employee, EmployeeDto>();
        }
    }
}