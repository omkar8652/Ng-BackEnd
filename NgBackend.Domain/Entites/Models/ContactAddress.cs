using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("contact_address")]
    public class ContactAddress 
    {
        public long? ContactAddressId{get; set;}        
        public int? ContactsId { get; set; }
        public string Street { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? Pincode { get; set; }
        public int? AddressTypeId { get; set; }
        public string IsPrimary { get; set; }
        public int? AddressProofId { get; set; }
        public long? DocsFileId { get; set; }
        public string AddressProofText { get; set; }
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
        //     var contactAddress = obj as ContactAddress;
        //     if (contactAddress?.Id == null || contactAddress?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, contactAddress.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ContactAddress{" +
                 //   $"ID='{Id}'" +
                    $", ContactsId='{ContactsId}'" +
                    $", Street='{Street}'" +
                    $", CityId='{CityId}'" +
                    $", StateId='{StateId}'" +
                    $", CountryId='{CountryId}'" +
                    $", Pincode='{Pincode}'" +
                    $", AddressTypeId='{AddressTypeId}'" +
                    $", IsPrimary='{IsPrimary}'" +
                    $", AddressProofId='{AddressProofId}'" +
                    $", DocsFileId='{DocsFileId}'" +
                    $", AddressProofText='{AddressProofText}'" +
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
