using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("merchant_processors")]
    public class MerchantProcessors 
    {
        [Key]
        public long? MerchantBankInfoId	{get; set;}
        public string IsDefault { get; set; }
        public int? BankId { get; set; }
        public string BranchName { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public int? MICR { get; set; }
        public string IFSC { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int? AccountTypeId { get; set; }
        public int? ECS { get; set; }
        public int? UserNumber { get; set; }
        public string UserName { get; set; }
        public string LedgerFolioNumber { get; set; }
        public long? UserCreditLimit { get; set; }
        public string UserCreditReference { get; set; }
        public int? Sequence { get; set; }
        public string EscrowAccountNumber { get; set; }
        public string EscrowAccountName { get; set; }
        public int? EscrowBankId { get; set; }
        public string EscrowBranchName { get; set; }
        public string DataModeFlg { get; set; }
        public DateTime? AccountCreatedSince { get; set; }
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
        //     var merchantProcessors = obj as MerchantProcessors;
        //     if (merchantProcessors?.Id == null || merchantProcessors?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, merchantProcessors.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "MerchantProcessors{" +
                 //   $"ID='{Id}'" +
                    $", IsDefault='{IsDefault}'" +
                    $", BankId='{BankId}'" +
                    $", BranchName='{BranchName}'" +
                    $", CityId='{CityId}'" +
                    $", Address='{Address}'" +
                    $", Pincode='{Pincode}'" +
                    $", MICR='{MICR}'" +
                    $", IFSC='{IFSC}'" +
                    $", AccountNumber='{AccountNumber}'" +
                    $", AccountName='{AccountName}'" +
                    $", AccountTypeId='{AccountTypeId}'" +
                    $", ECS='{ECS}'" +
                    $", UserNumber='{UserNumber}'" +
                    $", UserName='{UserName}'" +
                    $", LedgerFolioNumber='{LedgerFolioNumber}'" +
                    $", UserCreditLimit='{UserCreditLimit}'" +
                    $", UserCreditReference='{UserCreditReference}'" +
                    $", Sequence='{Sequence}'" +
                    $", EscrowAccountNumber='{EscrowAccountNumber}'" +
                    $", EscrowAccountName='{EscrowAccountName}'" +
                    $", EscrowBankId='{EscrowBankId}'" +
                    $", EscrowBranchName='{EscrowBranchName}'" +
                    $", DataModeFlg='{DataModeFlg}'" +
                    $", AccountCreatedSince='{AccountCreatedSince}'" +
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
