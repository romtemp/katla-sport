﻿using AutoMapper;
using DataAccessHive = KatlaSport.DataAccess.ProductStoreHive.StoreHive;
using DataAccessHiveSection = KatlaSport.DataAccess.ProductStoreHive.StoreHiveSection;

namespace KatlaSport.Services.HiveManagement
{
    public sealed class HiveManagementMappingProfile : Profile
    {
        public HiveManagementMappingProfile()
        {
            CreateMap<DataAccessHive, HiveListItem>();
            CreateMap<DataAccessHive, Hive>();
            CreateMap<DataAccessHiveSection, HiveSectionListItem>();
            CreateMap<DataAccessHiveSection, HiveSection>();
        }
    }
}
