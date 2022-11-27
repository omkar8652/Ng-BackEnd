using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("gst_detail_info")]
    public class GSTDetailInfo 
    {
        [Key]
        public long? GSTID { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string GSTIN { get; set; }
        public string GSTAddress { get; set; }
        public int? Pincode { get; set; }
        public int? StateId { get; set; }
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
        //     var gstDetailInfo = obj as GSTDetailInfo;
        //     if (gstDetailInfo?.Id == null || gstDetailInfo?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, gstDetailInfo.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "GSTDetailInfo{" +
                 //   $"ID='{Id}'" +
                    $", GSTID='{GSTID}'" +
                    $", DateOfRegistration='{DateOfRegistration}'" +
                    $", GSTIN='{GSTIN}'" +
                    $", GSTAddress='{GSTAddress}'" +
                    $", Pincode='{Pincode}'" +
                    $", StateId='{StateId}'" +
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
