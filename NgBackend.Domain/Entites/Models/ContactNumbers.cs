using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("contact_numbers")]
    public class ContactNumbers 
    {
        [Key]
        public long? ContactNumbersId{get; set;}
        public int? ContactsId { get; set; }
        public int? NumberType { get; set; }
        public string ContactNumber { get; set; }
        public string IsPrimary { get; set; }
        public long? ContactAdressId { get; set; }
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
        //     var contactNumbers = obj as ContactNumbers;
        //     if (contactNumbers?.Id == null || contactNumbers?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, contactNumbers.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ContactNumbers{" +
                 //   $"ID='{Id}'" +
                    $", ContactsId='{ContactsId}'" +
                    $", NumberType='{NumberType}'" +
                    $", ContactNumber='{ContactNumber}'" +
                    $", IsPrimary='{IsPrimary}'" +
                    $", ContactAdressId='{ContactAdressId}'" +
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
