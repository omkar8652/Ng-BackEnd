using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("utility_master")]
    public class UtilityMaster 
    {
        public string GroupCode { get; set; }
        public int? Type { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IsValid { get; set; }
        public string OtherVal { get; set; }
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
        //     var utilityMaster = obj as UtilityMaster;
        //     if (utilityMaster?.Id == null || utilityMaster?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, utilityMaster.Id);
        // }

        // //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "UtilityMaster{" +
                    // $"ID='{Id}'" +
                    $", GroupCode='{GroupCode}'" +
                    $", Type='{Type}'" +
                    $", Id='{Id}'" +
                    $", Name='{Name}'" +
                    $", Description='{Description}'" +
                    $", IsValid='{IsValid}'" +
                    $", OtherVal='{OtherVal}'" +
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
