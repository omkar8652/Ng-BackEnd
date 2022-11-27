using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("lead_source")]
    public class LeadSource 
    {
        [Key]
        public long? LeadSourceId{get; set;}   
        public string LeadSourceName { get; set; }
        public int? Sequence { get; set; }
        public string IsAgent { get; set; }
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
        //     var leadSource = obj as LeadSource;
        //     if (leadSource?.Id == null || leadSource?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, leadSource.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "LeadSource{" +
                 //   $"ID='{Id}'" +
                    $", LeadSourceName='{LeadSourceName}'" +
                    $", Sequence='{Sequence}'" +
                    $", IsAgent='{IsAgent}'" +
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
