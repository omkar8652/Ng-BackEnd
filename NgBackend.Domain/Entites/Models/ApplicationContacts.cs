using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("application_contacts")]
    public class ApplicationContacts 
    {
        [Key]
        public long? ApplicationContactsId { get; set; }
        public int? ContactsId { get; set; }
        public int? ContactTypeId { get; set; }
        public long? LeadId { get; set; }
        public long? ApplicationID { get; set; }
        public string IsPrimary { get; set; }
        public string IsVideoKYCApplicable { get; set; }
        public int? VideoKYCCurrentStatus { get; set; }
        public string VkycIdentifier { get; set; }
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
        //     var applicationContacts = obj as ApplicationContacts;
        //     if (applicationContacts?.Id == null || applicationContacts?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, applicationContacts.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "ApplicationContacts{" +
                 //   $"ID='{Id}'" +
                    $", ContactsId='{ContactsId}'" +
                    $", ContactTypeId='{ContactTypeId}'" +
                    $", LeadId='{LeadId}'" +
                    $", ApplicationID='{ApplicationID}'" +
                    $", IsPrimary='{IsPrimary}'" +
                    $", IsVideoKYCApplicable='{IsVideoKYCApplicable}'" +
                    $", VideoKYCCurrentStatus='{VideoKYCCurrentStatus}'" +
                    $", VkycIdentifier='{VkycIdentifier}'" +
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
