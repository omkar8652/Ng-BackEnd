using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("contact_relation_with_borrower")]
    public class ContactRelationWithBorrower
    {
        [Key]
        public long? RelationId { get; set; }
        public string RelationName { get; set; }
        public string Description { get; set; }
        public int? Sequence { get; set; }
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
        //     var contactRelationWithBorrower = obj as ContactRelationWithBorrower;
        //     if (contactRelationWithBorrower?.Id == null || contactRelationWithBorrower?.Id == 0 || Id == 0) return false;
        // //     return EqualityComparer<long>.Default.Equals(Id, contactRelationWithBorrower.Id);
        // }

        //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ContactRelationWithBorrower{" +
                    //   $"ID='{Id}'" +
                    $", RelationName='{RelationName}'" +
                    $", Description='{Description}'" +
                    $", Sequence='{Sequence}'" +
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
