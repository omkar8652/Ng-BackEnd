using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("application_cash_credit_litigation")]
    public class ApplicationCashCreditLitigation 
    {
        [Key]
        public long? LitigationId{get; set;}
        public string CaseNumber { get; set; }
        public DateTime DateOfCaseFiling { get; set; }
        public int? LitigationTypeId { get; set; }
        public string PendingWithAuthority { get; set; }
        public string Plaintiff { get; set; }
        public string Defendant { get; set; }
        public long? AmountInvolved { get; set; }
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
        //     var applicationCashCreditLitigation = obj as ApplicationCashCreditLitigation;
        //     if (applicationCashCreditLitigation?.Id == null || applicationCashCreditLitigation?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, applicationCashCreditLitigation.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ApplicationCashCreditLitigation{" +
                 //   $"ID='{Id}'" +
                    $", CaseNumber='{CaseNumber}'" +
                    $", DateOfCaseFiling='{DateOfCaseFiling}'" +
                    $", LitigationTypeId='{LitigationTypeId}'" +
                    $", PendingWithAuthority='{PendingWithAuthority}'" +
                    $", Plaintiff='{Plaintiff}'" +
                    $", Defendant='{Defendant}'" +
                    $", AmountInvolved='{AmountInvolved}'" +
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
