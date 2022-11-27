using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("customer_bank_info")]
    public class CustomerBankInfo 
    {
        [Key]
        public long? CustomerBankInfoId {get; set;}
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public int? AccountTypeId { get; set; }
        public string AccountNumber { get; set; }
        public DateTime? AccountOperatedSince { get; set; }
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
        //     var customerBankInfo = obj as CustomerBankInfo;
        //     if (customerBankInfo?.Id == null || customerBankInfo?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, customerBankInfo.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "CustomerBankInfo{" +
                 //   $"ID='{Id}'" +
                    $", BankName='{BankName}'" +
                    $", BranchName='{BranchName}'" +
                    $", AccountTypeId='{AccountTypeId}'" +
                    $", AccountNumber='{AccountNumber}'" +
                    $", AccountOperatedSince='{AccountOperatedSince}'" +
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
