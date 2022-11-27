using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("business_contact_numbers")]
    public class BusinessContactNumbers
    {
        [Key]
        public long? BusinessContactNumbersId { get; set; }
        public long? BusinessId { get; set; }
        public int? NumberType { get; set; }
        public string ContactNumber { get; set; }
        public string IsPrimary { get; set; }
        public long? BusinessAddressId { get; set; }
        public int? Businessflag { get; set; }
        public int? BAddressflag { get; set; }
        public string UserId { get; set; }
        public long? ApplicationContactAdressId { get; set; }
        public int? CAddressflag { get; set; }
        public int? Contactflag { get; set; }
        public int? ApplicationContactsId { get; set; }
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
        //     var businessContactNumbers = obj as BusinessContactNumbers;
        //     if (businessContactNumbers?.Id == null || businessContactNumbers?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, businessContactNumbers.Id);
        // }

        //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "BusinessContactNumbers{" +
                    //   $"ID='{Id}'" +
                    $", BusinessId='{BusinessId}'" +
                    $", NumberType='{NumberType}'" +
                    $", ContactNumber='{ContactNumber}'" +
                    $", IsPrimary='{IsPrimary}'" +
                    $", BusinessAddressId='{BusinessAddressId}'" +
                    $", Businessflag='{Businessflag}'" +
                    $", BAddressflag='{BAddressflag}'" +
                    $", UserId='{UserId}'" +
                    $", ApplicationContactAdressId='{ApplicationContactAdressId}'" +
                    $", CAddressflag='{CAddressflag}'" +
                    $", Contactflag='{Contactflag}'" +
                    $", ApplicationContactsId='{ApplicationContactsId}'" +
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
