using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("contact_number_type")]
    public class ContactNumberType
    {
        [Key]
        public long? ContactNumberTypeId { get; set; }
        public string NumberTypeName { get; set; }
        public int? Sequence { get; set; }
        public string IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string OrgId { get; set; }
        public string ClientId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public decimal? UUID { get; set; }
        public double? Version { get; set; }

        // jhipster-needle-entity-add-field - JHipster will add fields here, do not remove

        // public override bool Equals(object obj)
        // {
        //     if (this == obj) return true;
        //     if (obj == null || GetType() != obj.GetType()) return false;
        //     var contactNumberType = obj as ContactNumberType;
        //     if (contactNumberType?.Id == null || contactNumberType?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, contactNumberType.Id);
        // }

        //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ContactNumberType{" +
                    //   $"ID='{Id}'" +
                    $", NumberTypeName='{NumberTypeName}'" +
                    $", Sequence='{Sequence}'" +
                    $", IsActive='{IsActive}'" +
                    $", ImageUrl='{ImageUrl}'" +
                    $", OrgId='{OrgId}'" +
                    $", ClientId='{ClientId}'" +
                    $", CreatedBy='{CreatedBy}'" +
                    $", CreatedDate='{CreatedDate}'" +
                    $", UpdatedBy='{UpdatedBy}'" +
                    $", UpdatedDate='{UpdatedDate}'" +
                    $", UUID='{UUID}'" +
                    $", Version='{Version}'" +
                    "}";
        }
    }
}
