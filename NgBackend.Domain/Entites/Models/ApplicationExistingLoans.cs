using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("application_existing_loans")]
    public class ApplicationExistingLoans 
    {
        [Key]
        public string ApplicationExistingLoansId { get; set; }
        public string FinancierName { get; set; }
        public int? LoanTypeId { get; set; }
        public long? Amount { get; set; }
        public DateTime StartingDate { get; set; }
        public long? MonthlyEMI { get; set; }
        public int? TenureInMonths { get; set; }
        public long? Balance { get; set; }
        public string OrgId { get; set; }
        public string ClientId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public decimal? UUID { get; set; }
        public double? Version { get; set; }
        public string IsActive { get; set; }

        // jhipster-needle-entity-add-field - JHipster will add fields here, do not remove

        // public override bool Equals(object obj)
        // {
        //     if (this == obj) return true;
        //     if (obj == null || GetType() != obj.GetType()) return false;
        //     var applicationExistingLoans = obj as ApplicationExistingLoans;
        //     if (applicationExistingLoans?.Id == null || applicationExistingLoans?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, applicationExistingLoans.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ApplicationExistingLoans{" +
                 //   $"ID='{Id}'" +
                    $", FinancierName='{FinancierName}'" +
                    $", LoanTypeId='{LoanTypeId}'" +
                    $", Amount='{Amount}'" +
                    $", StartingDate='{StartingDate}'" +
                    $", MonthlyEMI='{MonthlyEMI}'" +
                    $", TenureInMonths='{TenureInMonths}'" +
                    $", Balance='{Balance}'" +
                    $", OrgId='{OrgId}'" +
                    $", ClientId='{ClientId}'" +
                    $", CreatedBy='{CreatedBy}'" +
                    $", CreatedDate='{CreatedDate}'" +
                    $", UpdatedBy='{UpdatedBy}'" +
                    $", UpdatedDate='{UpdatedDate}'" +
                    $", UUID='{UUID}'" +
                    $", Version='{Version}'" +
                    $", IsActive='{IsActive}'" +
                    "}";
        }
    }
}
