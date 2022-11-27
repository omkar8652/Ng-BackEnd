using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("mst_external_agents")]
    public class MstExternalAgents 
    {
        [Key]
        public long? ExternalAgentId { get; set; }
        public string ExternalAgentType { get; set; }
        public string AgentId { get; set; }
        public string FullName { get; set; }
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
        //     var mstExternalAgents = obj as MstExternalAgents;
        //     if (mstExternalAgents?.Id == null || mstExternalAgents?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, mstExternalAgents.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "MstExternalAgents{" +
                 //   $"ID='{Id}'" +
                    $", ExternalAgentId='{ExternalAgentId}'" +
                    $", ExternalAgentType='{ExternalAgentType}'" +
                    $", AgentId='{AgentId}'" +
                    $", FullName='{FullName}'" +
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
