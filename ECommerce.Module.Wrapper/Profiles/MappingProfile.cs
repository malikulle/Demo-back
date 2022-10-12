using AutoMapper;
using ECommerce.Data.Domain.AddressBook;
using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Domain.Enums.Configuration;
using ECommerce.Data.Domain.Logging;
using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Domain.Sales;
using ECommerce.Framework.SharedLibary.Paging;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.City;
using ECommerce.Module.Wrapper.ServiceModels.AddressBook.Country;
using ECommerce.Module.Wrapper.ServiceModels.Catalog;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.Product;
using ECommerce.Module.Wrapper.ServiceModels.Catalog.ProductComment;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Job;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.JobExecution;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Language;
using ECommerce.Module.Wrapper.ServiceModels.Configuration.Parameter;
using ECommerce.Module.Wrapper.ServiceModels.Logging.AuiditLog;
using ECommerce.Module.Wrapper.ServiceModels.Logging.ExceptionLog;
using ECommerce.Module.Wrapper.ServiceModels.Membership;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Permission;
using ECommerce.Module.Wrapper.ServiceModels.Membership.Role;
using ECommerce.Module.Wrapper.ServiceModels.Membership.RolePermission;
using ECommerce.Module.Wrapper.ServiceModels.Membership.User;
using ECommerce.Module.Wrapper.ServiceModels.Sales.Basket;
using ECommerce.Module.Wrapper.ServiceModels.Sales.BasketItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Module.Wrapper.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            #region AddressBook
            this.CreateMap<CityModel, City>().ReverseMap();
            this.CreateMap<IPaginate<City>, CityPaginationResponse>().ReverseMap();

            this.CreateMap<CountryModel, Country>().ReverseMap();
            this.CreateMap<IPaginate<Country>, CountryPaginationResponse>().ReverseMap();
            #endregion

            #region Catalog
            this.CreateMap<CategoryModel, Category>().ReverseMap();
            this.CreateMap<CategoryModel_i18n, Category_i18n>().ReverseMap();
            this.CreateMap<CategoryResponse, Category>().ReverseMap();

            this.CreateMap<IPaginate<Category>, CategoryPaginationReponse>().ReverseMap();

            this.CreateMap<ProductModel, Product>().ReverseMap();
            this.CreateMap<ProductModel_i18n, Product_i18n>().ReverseMap();
            this.CreateMap<IPaginate<Product>, ProductPaginationResponse>().ReverseMap();

            this.CreateMap<ProductComment, ProductCommentModel>()
                .ForMember(op => op.ImagePath, opt => opt.MapFrom(op => op.User.ImagePath))
                .ForMember(op => op.FullName, opt => opt.MapFrom(op => op.User.FullName))
                .ReverseMap();
            this.CreateMap<IPaginate<ProductComment>, ProductCommentPaginationResponse>().ReverseMap();
            #endregion

            #region Membership
            this.CreateMap<User, UserRegisterModel>().ReverseMap();
            this.CreateMap<User, UserRegisteredModel>().ReverseMap();

            this.CreateMap<User, UserLoginResponse>().ReverseMap();

            this.CreateMap<User, UserModel>().ForMember(op => op.RoleName, opt => opt.MapFrom(op => op.Role.Name)).ReverseMap();
            this.CreateMap<IPaginate<User>, UserPaginationResponse>().ReverseMap();

            this.CreateMap<Permission, PermissionModel>().ReverseMap();
            this.CreateMap<IPaginate<Permission>, PermissionPaginationResponse>().ReverseMap();

            this.CreateMap<Role, RoleModel>().ReverseMap();
            this.CreateMap<IPaginate<Role>, RolePaginationResponse>().ReverseMap();

            this.CreateMap<RolePermission, RolePermissionModel>().ReverseMap();
            this.CreateMap<RoleUpdateModel, Role>().ReverseMap();
            #endregion

            #region Configuration            

            this.CreateMap<Language, LanguageModel>().ReverseMap();
            this.CreateMap<IPaginate<Language>, LanguagePaginationResponse>().ReverseMap();

            this.CreateMap<Parameter, ParameterModel>().ReverseMap();
            this.CreateMap<IPaginate<Parameter>, ParameterPaginationResponse>().ReverseMap();

            this.CreateMap<Job, JobModel>().ReverseMap();
            this.CreateMap<IPaginate<Job>, JobPaginationResponse>().ReverseMap();

            this.CreateMap<JobExecution, JobExecutionModel>().ForMember(op => op.JobName, opt => opt.MapFrom(op => op.Job.Name)).ForMember(op => op.JobExecutionTypeName, opt => opt.MapFrom(op => ((JobExecutionType)op.JobExecutionType).ToString())).ReverseMap();
            this.CreateMap<IPaginate<JobExecution>, JobExecutionPaginationResponse>().ReverseMap();

            this.CreateMap<JobExecutionDetail, JobExecutionDetailModel>().ReverseMap();
            #endregion

            #region Logging
            this.CreateMap<ExceptionLog, ExceptionLogModel>();
            this.CreateMap<IPaginate<ExceptionLog>, ExceptionLogPaginationResponse>().ReverseMap();

            this.CreateMap<AuditLog, AuditLogModel>();
            this.CreateMap<IPaginate<AuditLog>, AuditLogPaginationResponse>().ReverseMap();
            #endregion

            #region Sales
            this.CreateMap<Basket, BasketModel>().ReverseMap();
            this.CreateMap<BasketItem, BasketItemModel>()
                .ForMember(op => op.ProductName, opt => opt.MapFrom(op => op.Product.Name))
                .ForMember(op => op.ImagePath, opt => opt.MapFrom(op => op.Product.ImagePath))
                .ReverseMap();

            #endregion
        }
    }
}
