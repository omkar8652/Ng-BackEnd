using System.Text;
using Confluent.Kafka;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NgBackend.Application.Interfaces.ExternalServiceCall;
using NgBackend.Application.Interfaces.Persistence;
using NgBackend.Domain.Adapters;
using NgBackend.Domain.Entites.Models;
using NgBackend.Infrastructure.Kafka;
using NgBackend.Infrastructure.Services.ExternalServiceCall;
using NgBackend.Infrastructure.Services.Persistence;
using Polly;
using Polly.Extensions.Http;

namespace NgBackend.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            // ProducerConfig
            // Console.WriteLine(configuration["CamundaApi:url"]);
            // services.AddSingleton<IJwtTokenGen, JwtTokenGen>();
            // services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IExternalSerivce, ExternalServiceCalls>();
            services.AddScoped<IMstTitlesRepo, MstTitlesRepo>();
            services.AddScoped<IMstBusinessUnit, MstBusinessUnitRepo>();
            services.AddScoped<IMstSource, MstSourceRepo>();
            services.AddScoped<IMstInternalAgents, MstInternalAgentsRepo>();
            services.AddScoped<IMstExternalAgents, MstExternalAgentsRepo>();
            services.AddScoped<IMstDsa, MstDsaRepo>();
            services.AddScoped<IMstAgents, MstAgentsRepo>();
            services.AddScoped<IMstBranch, MstBranchRepo>();
            services.AddScoped<IMstRegions, MstRegionsRepo>();
            services.AddScoped<IMstScheme, MstSchemeRepo>();
            services.AddScoped<IApplicationPurposeOfLoan, ApplicationPurposeOfLoanRepo>();
            services.AddScoped<IMstUser, MstUserRepo>();
            services.AddScoped<IUtilityMaster, UtilityMasterRepo>();
            services.AddScoped<IMstBusinessEntityType, MstBusinessEntityTypeRepo>();
            services.AddScoped<IBusinessNature, BusinessNatureRepo>();
            services.AddScoped<IMstControlProgram, MstControlProgramRepo>();
            services.AddScoped<IMstIndustry, MstIndustryRepo>();
            services.AddScoped<IMstOmc, MstOmcRepo>();
            services.AddScoped<IMstPremisesType, MstPremisesTypeRepo>();
            services.AddScoped<IMstCountry, MstCountryRepo>();
            services.AddScoped<IMstState, MstStateRepo>();
            services.AddScoped<IMstCity, MstCityRepo>();
            services.AddScoped<IContactNumberType, ContactNumberTypeRepo>();
            services.AddScoped<IBusinessAddress, BusinessAddressRepo>();
            services.AddScoped<IContactRelationWithBorrower, ContactRelationWithBorrowerRepo>();
            services.AddScoped<IContactModeOfCommunication, ContactModeOfCommunicationRepo>();
            services.AddScoped<IMstMarStatus, MstMarStatusRepo>();
            services.AddScoped<IMstOccupationType, MstOccupationTypeRepo>();
            services.AddScoped<IMstEducationType, MstEducationTypeRepo>();
            services.AddScoped<ICustomerBankInfo, CustomerBankInfoRepo>();
            services.AddScoped<IMstAddressProof, MstAddressProofRepo>();
            services.AddScoped<IMstAccountType, MstAccountTypeRepo>();
            services.AddScoped<IMstBusinessRegistered, MstBusinessRegisteredRepo>();
            services.AddScoped<ConfigAdapters>();
        


            services.AddHttpClient<IExternalSerivce, ExternalServiceCalls>("camundaClient", c =>
            c.BaseAddress = new Uri(configuration["CamundaApi:url"]))
            .AddPolicyHandler(getRetryPolicy())
            // .AddTransientHttpErrorPolicy(policy => policy.)
            // .AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(3, _ =>
            // {
            //     Console.WriteLine("Wait And Retry");
            //     return TimeSpan.FromSeconds(20);
            // }))
            .AddTransientHttpErrorPolicy(policy => policy.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));
            services.AddHttpClient("testApi", c =>
               c.BaseAddress = new Uri("https://localhost:7155/"))
               .AddPolicyHandler(getRetryPolicy())
               .AddTransientHttpErrorPolicy(policy => policy.CircuitBreakerAsync(5, TimeSpan.FromSeconds(30)));

            // services.AddScoped<IUDMapperRepo, UDMapperRepo>();
            // services.AddScoped<IDepartmentRepo, DepartmentRepo>();
            // services.AddScoped<Messages>();
            // services.AddScoped<MessageDomain>();
            // services.AddScoped<ConfigAdapters>();
            // // services.AddSingleton<HttpClient>();

            services.AddSingleton<ConfigurationBuilder>();
            services.AddScoped<KafkaProducer>();
            services.AddScoped<KafkaConsumer>();
            services.Configure<ProducerConfig>("kafkaProducer", configuration.GetSection("KafkaProducer"));
            services.Configure<ConsumerConfig>("kafkaConsumer", configuration.GetSection("KafkaConsumer"));
            // services.AddScoped<ProducerConfig>(cf=>{
            //     switch (cf){
            //         case 1:
            //         return new ProducerConfig{};

            //     }
            // });


            // services.AddAuth(configuration);
            // services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme);
            return services;
        }


        private static IAsyncPolicy<HttpResponseMessage> getRetryPolicy()
        {
            return HttpPolicyExtensions
                    .HandleTransientHttpError()
                    .WaitAndRetryAsync(
                        retryCount: 3,
                        sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(20),
                        onRetry: (exception, retrycount, context) =>
                        {
                            Console.WriteLine(exception.Result + " " + retrycount + " " + context.PolicyKey);
                        }

                    );
        }


        // public static IServiceCollection AddAuth(this IServiceCollection services, ConfigurationManager configuration)
        // {
        //     services.Configure<JwtSettings>(configuration.GetSection("Jwt"));
        //     services.AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
        //     .AddJwtBearer(options =>
        //     {
        //         options.TokenValidationParameters = new TokenValidationParameters()
        //         {
        //             ValidateAudience = true,
        //             ValidateIssuer = true,
        //             ValidateIssuerSigningKey = true,
        //             ValidateLifetime = true,
        //             ValidIssuer = "LORD",
        //             ValidAudience = "LORD",
        //             IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("ThisismySecretKey"))
        //         }; options.RequireHttpsMetadata = false;
        //     });
        //     return services;
        // }
        // eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJlOWNlMmFhZC04MGRjLTQxYjktOTVmMC1kYzgwNzY3Y2I1ODciLCJqdGkiOiIzYTQwMjRiZC0zMDcwLTQxOTctYTJmZC0xNjYxNGMzOWFjNjAiLCJmYW1pbHlfbmFtZSI6InN0cmluZyIsImV4cCI6MTY2ODE3ODcyMiwiaXNzIjoiTE9SRCJ9.n_O1OXLh-3ToS--EgkC3NoXLctGZdgBMBLLjl2YBLCo


    }
}