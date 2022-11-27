using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("ng_directors_matrix")]
    public class NGDirectorsMatrix 
    {
        [Key]
        public long? Id  { get; set; }
        public string DirectorName { get; set; }
        public string DIN { get; set; }
        public string PAN { get; set; }
        public DateTime DateOfInactive { get; set; }
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
        //     var ngDirectorsMatrix = obj as NGDirectorsMatrix;
        //     if (ngDirectorsMatrix?.Id == null || ngDirectorsMatrix?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, ngDirectorsMatrix.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "NGDirectorsMatrix{" +
                 //   $"ID='{Id}'" +
                    $", DirectorName='{DirectorName}'" +
                    $", DIN='{DIN}'" +
                    $", PAN='{PAN}'" +
                    $", DateOfInactive='{DateOfInactive}'" +
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
