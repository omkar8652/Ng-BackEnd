using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("repay_mechanism_master")]
    public class RepayMechanismMaster
    {
        [Key]
        public long? Id  { get; set; }
        public int? PickType { get; set; }
        public string PickUpValue { get; set; }
        public string PickUpId { get; set; }
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
        //     var repayMechanismMaster = obj as RepayMechanismMaster;
        //     if (repayMechanismMaster?.Id == null || repayMechanismMaster?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, repayMechanismMaster.Id);
        // }

        //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "RepayMechanismMaster{" +
                    //   $"ID='{Id}'" +
                    $", PickType='{PickType}'" +
                    $", PickUpValue='{PickUpValue}'" +
                    $", PickUpId='{PickUpId}'" +
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
