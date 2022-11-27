using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mapster;
using NgBackend.Domain.Entites.DTOs;
using NgBackend.Domain.Entites.Models;

namespace NgBackend.Domain.Adapters
{
    public class ConfigAdapters
    {
        public ConfigAdapters()
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.NewConfig<ApplicationDTO, Applications>().Map(dest => dest, src => src);
            config.NewConfig<CustBankInfoDTO, CustomerBankInfo>().Map(dest => dest, src => src);
            config.NewConfig<MainDTO, Applications>().Map(dest => dest, src => src.applicationDTO);
        }
    }
}