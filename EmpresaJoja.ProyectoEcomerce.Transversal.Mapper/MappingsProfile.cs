using System;
using AutoMapper;
using EmpresaJoja.ProyectoEcomerce.Domain.Entity;
using EmpresaJoja.ProyectoEcomerce.Application.DTO;

namespace EmpresaJoja.ProyectoEcomerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDto>().ReverseMap();

            //CreateMap<Customers, CustomersDto>().ReverseMap()
            //    .ForMember(destination => destination.CustomesId, sourcer => sourcer.MapFrom(src => src.CustomesId))
            //    .ForMember(destination => destination.CompanyName, sourcer => sourcer.MapFrom(src => src.CompanyName))
            //    .ForMember(destination => destination.ContactName, sourcer => sourcer.MapFrom(src => src.ContactName))
            //    .ForMember(destination => destination.ContactTitle, sourcer => sourcer.MapFrom(src => src.ContactTitle))
            //    .ForMember(destination => destination.Addres, sourcer => sourcer.MapFrom(src => src.Addres))
            //    .ForMember(destination => destination.City, sourcer => sourcer.MapFrom(src => src.City))
            //    .ForMember(destination => destination.Region, sourcer => sourcer.MapFrom(src => src.Region))
            //    .ForMember(destination => destination.PostalCode, sourcer => sourcer.MapFrom(src => src.PostalCode))
            //    .ForMember(destination => destination.Country, sourcer => sourcer.MapFrom(src => src.Country))
            //    .ForMember(destination => destination.Fax, sourcer => sourcer.MapFrom(src => src.Fax)).ReverseMap();

        }

    }
}
