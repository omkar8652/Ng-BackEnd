using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("mst_internal_agents")]
    public class MstInternalAgents 
    {
        [Key]
        public long? InternalAgentId { get; set; }
        public string InternalAgentType { get; set; }
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
        //     var mstInternalAgents = obj as MstInternalAgents;
        //     if (mstInternalAgents?.Id == null || mstInternalAgents?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, mstInternalAgents.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "MstInternalAgents{" +
                 //   $"ID='{Id}'" +
                    $", InternalAgentId='{InternalAgentId}'" +
                    $", InternalAgentType='{InternalAgentType}'" +
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
