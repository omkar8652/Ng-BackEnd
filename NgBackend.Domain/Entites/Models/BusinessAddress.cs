using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("business_address")]
    public class BusinessAddress 
    {
        [Key]
        public long? BusinessAddressId { get; set; }
        public long? BusinessId { get; set; }
        public string Street { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? Pincode { get; set; }
        public int? AddressTypeId { get; set; }
        public string IsPrimary { get; set; }
        public int? Businessflag { get; set; }
        public int? BAddressflag { get; set; }
        public string UserId { get; set; }
        public long? AddressProofId { get; set; }
        public long? DocsFIleId { get; set; }
        public string CIN { get; set; }
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
        //     var businessAddress = obj as BusinessAddress;
        //     if (businessAddress?.Id == null || businessAddress?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, businessAddress.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "BusinessAddress{" +
                 //   $"ID='{Id}'" +
                    $", BusinessId='{BusinessId}'" +
                    $", Street='{Street}'" +
                    $", CityId='{CityId}'" +
                    $", StateId='{StateId}'" +
                    $", CountryId='{CountryId}'" +
                    $", Pincode='{Pincode}'" +
                    $", AddressTypeId='{AddressTypeId}'" +
                    $", IsPrimary='{IsPrimary}'" +
                    $", Businessflag='{Businessflag}'" +
                    $", BAddressflag='{BAddressflag}'" +
                    $", UserId='{UserId}'" +
                    $", AddressProofId='{AddressProofId}'" +
                    $", DocsFIleId='{DocsFIleId}'" +
                    $", CIN='{CIN}'" +
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
