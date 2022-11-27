using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

// using BuberDinner.domain.Entites;
using Microsoft.EntityFrameworkCore;
using NgBackend.Domain.Entites.Models;
using NgBackend.Domain.Entites.Models.Interfaces;

namespace NgBackend.Infrastructure.Data
{
    public class DotNetDBcontext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DotNetDBcontext(DbContextOptions options) : base(options)
        {
        }

        protected DotNetDBcontext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer(@"server=NUCDBSRV\NUCDB2014;database=Ngdev ;user id=sa;password=nuc1234$", b => b.MigrationsAssembly("NgBackend.API"));
            optionsBuilder.UseSqlServer(@"server=OMKAR-LAPTOP\SQLEXPRESS;database=Ngdev ; Integrated Security=True", b => b.MigrationsAssembly("NgBackend.API"));
        }

        // public DbSet<User> user { get; set; }




        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder); //added by bharat
        //     modelBuilder.Entity<User>().Ignore(p => p.map);
        // }

        public DbSet<MstTitles> MstTitles { get; set; }
        public DbSet<MstCity> MstCities { get; set; }
        public DbSet<MstState> MstStates { get; set; }
        public DbSet<MstCountry> MstCountries { get; set; }
        public DbSet<MstScheme> MstSchemes { get; set; }
        public DbSet<ApplicationReference> ApplicationReferences { get; set; }
        public DbSet<MstBusinessEntityType> MstBusinessEntityTypes { get; set; }
        public DbSet<MstBusinessRegistered> MstBusinessRegistereds { get; set; }
        public DbSet<MstBranch> MstBranches { get; set; }
        public DbSet<MstRegion> MstRegions { get; set; }
        public DbSet<MstDsa> MstDsas { get; set; }
        public DbSet<MstEdcTerminal> MstEdcTerminals { get; set; }
        public DbSet<MstBusinessUnit> MstBusinessUnits { get; set; }
        public DbSet<MstSource> MstSources { get; set; }
        public DbSet<MstDocsFile> MstDocsFiles { get; set; }
        public DbSet<MstMarStatus> MstMarStatuses { get; set; }
        public DbSet<MstOccupationType> MstOccupationTypes { get; set; }
        public DbSet<MstOmc> MstOmcs { get; set; }
        public DbSet<MstIndustry> MstIndustries { get; set; }
        public DbSet<MstSubIndustry> MstSubIndustries { get; set; }
        public DbSet<MstAddressProof> MstAddressProofs { get; set; }
        public DbSet<MstEducationType> MstEducationTypes { get; set; }
        public DbSet<MstUser> MstUsers { get; set; }
        public DbSet<ContactNumberType> ContactNumberTypes { get; set; }
        public DbSet<ContactRelationWithBorrower> ContactRelationWithBorrowers { get; set; }
        public DbSet<ContactModeOfCommunication> ContactModeOfCommunications { get; set; }
        public DbSet<BusinessNature> BusinessNatures { get; set; }
        public DbSet<MstAddress> MstAddresses { get; set; }
        public DbSet<MstAddressType> MstAddressTypes { get; set; }
        public DbSet<MstPremisesType> MstPremisesTypes { get; set; }
        public DbSet<MstAccountType> MstAccountTypes { get; set; }
        public DbSet<CustomerBankInfo> CustomerBankInfos { get; set; }
        public DbSet<ApplicationPurposeOfLoan> ApplicationPurposeOfLoans { get; set; }
        public DbSet<RepayMechanismMaster> RepayMechanismMasters { get; set; }
        public DbSet<LeadSource> LeadSources { get; set; }
        public DbSet<UtilityMaster> UtilityMasters { get; set; }
        public DbSet<NGDirectorsMatrix> NGDirectorsMatrices { get; set; }
        public DbSet<ApplicationBusiness> ApplicationBusinesses { get; set; }
        public DbSet<BusinessAddress> BusinessAddresses { get; set; }
        public DbSet<BusinessContactNumbers> BusinessContactNumbers { get; set; }
        public DbSet<ApplicationContacts> ApplicationContacts { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        public DbSet<ContactNumbers> ContactNumbers { get; set; }
        public DbSet<MerchantBankInfo> MerchantBankInfos { get; set; }
        public DbSet<MerchantProcessors> MerchantProcessors { get; set; }
        public DbSet<GSTMasterInfo> GSTMasterInfos { get; set; }
        public DbSet<MstCustType> MstCustTypes { get; set; }
        public DbSet<GSTDetailInfo> GSTDetailInfos { get; set; }
        public DbSet<ApplicationExistingLoans> ApplicationExistingLoans { get; set; }
        public DbSet<ApplicationCashCreditODLimits> ApplicationCashCreditODLimits { get; set; }
        public DbSet<ApplicationCashCreditLitigation> ApplicationCashCreditLitigations { get; set; }
        public DbSet<MstAgents> MstAgents { get; set; }
        public DbSet<MstInternalAgents> MstInternalAgents { get; set; }
        public DbSet<MstExternalAgents> MstExternalAgents { get; set; }
        public DbSet<MstControlProgram> MstControlPrograms { get; set; }
        public DbSet<BusinessDetails> BusinessDetails { get; set; }
        public DbSet<Applications> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Applications>()
            .HasKey(o => new { o.AppLeadId, o.LeadId });

        //     builder.Entity<Applications>()
        //     .HasOne(a => a.ApplicationCashCreditLitigation).WithOne(b => b.Applications).HasForeignKey<ApplicationCashCreditLitigation>(e => e.LitigationId);

        //     builder.Entity<Applications>()
        //   .HasOne(a => a.MstExternalAgents).WithOne(b => b.Applications).HasForeignKey<MstExternalAgents>(e => e.AgentId);

        //     builder.Entity<Applications>()
        //     .HasOne(a => a.MstInternalAgents).WithOne(b => b.Applications).HasForeignKey<MstInternalAgents>(e => e.AgentId);
            // builder.Entity<Applications>().HasOne(a => a.LitigationId).WithOne(b => b.Applications).HasForeignKey<ApplicationCashCreditLitigation>(e => e.);

        }


        /// <summary>
        /// SaveChangesAsync with entities audit
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        // public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        // {
        //     var entries = ChangeTracker
        //       .Entries()
        //       .Where(e => e.Entity is IAuditedEntityBase && (
        //           e.State == EntityState.Added
        //           || e.State == EntityState.Modified));

        //     string modifiedOrCreatedBy = _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "System";

        //     foreach (var entityEntry in entries)
        //     {
        //         if (entityEntry.State == EntityState.Added)
        //         {
        //             ((IAuditedEntityBase)entityEntry.Entity).CreatedDate = DateTime.Now;
        //             ((IAuditedEntityBase)entityEntry.Entity).CreatedBy = modifiedOrCreatedBy;
        //         }
        //         else
        //         {
        //             Entry((IAuditedEntityBase)entityEntry.Entity).Property(p => p.CreatedDate).IsModified = false;
        //             Entry((IAuditedEntityBase)entityEntry.Entity).Property(p => p.CreatedBy).IsModified = false;
        //         }
        //       ((IAuditedEntityBase)entityEntry.Entity).LastModifiedDate = DateTime.Now;
        //         ((IAuditedEntityBase)entityEntry.Entity).LastModifiedBy = modifiedOrCreatedBy;
        //     }
        //     return await base.SaveChangesAsync(cancellationToken);
        // }

    }
}