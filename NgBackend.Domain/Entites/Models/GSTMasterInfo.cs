using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("gst_master_info")]
    public class GSTMasterInfo 
    {
        [Key]
        public long? GSTID	{get; set;}
        public long? ApplicationId { get; set; }
        public int? CustomerTypeId { get; set; }
        public string GSTExcepNo { get; set; }
        public int? TotalNoOfGST { get; set; }
        public string SourceType { get; set; }
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
        //     var gstMasterInfo = obj as GSTMasterInfo;
        //     if (gstMasterInfo?.Id == null || gstMasterInfo?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, gstMasterInfo.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "GSTMasterInfo{" +
                 //   $"ID='{Id}'" +
                    $", ApplicationId='{ApplicationId}'" +
                    $", CustomerTypeId='{CustomerTypeId}'" +
                    $", GSTExcepNo='{GSTExcepNo}'" +
                    $", TotalNoOfGST='{TotalNoOfGST}'" +
                    $", SourceType='{SourceType}'" +
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
