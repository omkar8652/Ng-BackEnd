using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("application_reference")]
    public class ApplicationReference 
    {
        [Key]
        public int? ApplicationReferenceId { get; set; }
        public string ApplicationReferenceName { get; set; }
        public int? TitleId { get; set; }
        public int? RelationId { get; set; }
        public int? NumberTypeId { get; set; }
        public string IsPrimary { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? StateId { get; set; }
        public string Description { get; set; }
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
        //     var applicationReference = obj as ApplicationReference;
        //     if (applicationReference?.Id == null || applicationReference?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, applicationReference.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ApplicationReference{" +
                 //   $"ID='{Id}'" +
                    $", ApplicationReferenceId='{ApplicationReferenceId}'" +
                    $", ApplicationReferenceName='{ApplicationReferenceName}'" +
                    $", TitleId='{TitleId}'" +
                    $", RelationId='{RelationId}'" +
                    $", NumberTypeId='{NumberTypeId}'" +
                    $", IsPrimary='{IsPrimary}'" +
                    $", FirstName='{FirstName}'" +
                    $", MiddleName='{MiddleName}'" +
                    $", LastName='{LastName}'" +
                    $", StateId='{StateId}'" +
                    $", Description='{Description}'" +
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
