using AutoMapper;
using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.models;

namespace danske.scheduler.producer.api.profiles
{
    public class CompanyProfile:Profile
    {
        public CompanyProfile()
        {
            CreateMap<CompanyDto, Company>();
        }
    }
}
