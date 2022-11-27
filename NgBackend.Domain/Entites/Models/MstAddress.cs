using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("mst_address")]
    public class MstAddress 
    {
        [Key]
        public int? AddressId { get; set; }
        [Required]
        public int? AddressTypeId { get; set; }
        [Required]
        public int? AddressProofId { get; set; }
        public string AddressType { get; set; }
        public string AddressSubType { get; set; }
        public string ContactAddressflag { get; set; }
        public string ContactAddressSubflag { get; set; }
        public string BusinessAddressflag { get; set; }
        public string BusinessAddressSubflag { get; set; }
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
        //     var mstAddress = obj as MstAddress;
        //     if (mstAddress?.Id == null || mstAddress?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, mstAddress.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "MstAddress{" +
                 //   $"ID='{Id}'" +
                    $", AddressId='{AddressId}'" +
                    $", AddressTypeId='{AddressTypeId}'" +
                    $", AddressProofId='{AddressProofId}'" +
                    $", AddressType='{AddressType}'" +
                    $", AddressSubType='{AddressSubType}'" +
                    $", ContactAddressflag='{ContactAddressflag}'" +
                    $", ContactAddressSubflag='{ContactAddressSubflag}'" +
                    $", BusinessAddressflag='{BusinessAddressflag}'" +
                    $", BusinessAddressSubflag='{BusinessAddressSubflag}'" +
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
