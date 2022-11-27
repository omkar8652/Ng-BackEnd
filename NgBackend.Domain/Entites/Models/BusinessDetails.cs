using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("business_details")]
    public class BusinessDetails
    {
        [Key]
        public long? BusinessDetailsId { get; set; }
        public string CompanyName { get; set; }
        public string TradingName { get; set; }
        public int? BusinessNatureId { get; set; }
        public int? IndustryId { get; set; }
        public int? SubIndustryId { get; set; }
        public int? PremisesTypeId { get; set; }
        public int? AreaOfShop { get; set; }
        public DateTime DoingBusinessSince { get; set; }
        public string PAN { get; set; }
        public string TAN { get; set; }
        public string WebAddress { get; set; }
        public string WeeklyOff { get; set; }
        public DateTime OccupiedSince { get; set; }
        public long? CashSales { get; set; }
        public string CardSales { get; set; }
        public int? ModeOfCommunicationId { get; set; }
        public int? RelationId { get; set; }
        public string ContactPersonFirstName { get; set; }
        public string ContactPersonMiddleName { get; set; }
        public string ContactPersonLastName { get; set; }
        public string ContactPersonDesignation { get; set; }
        public int? ContactPersonTitleID { get; set; }
        public string AssociatedBusinessIds { get; set; }
        public int? Businessflag { get; set; }
        public string UserId { get; set; }
        public string ControlProgram { get; set; }
        public int? SubSupplierId { get; set; }
        public string DealerCode { get; set; }
        public string OMCName { get; set; }
        public string CompanyNameAsPerNSDL { get; set; }
        public int? NSDLStatus { get; set; }
        public string Verified { get; set; }
        public string IsAnyOtherBusinessEntity { get; set; }
        public string UdhyogAadharNumber { get; set; }
        public int? PreferredAddress { get; set; }
        public string EmailID { get; set; }
        public string MeetingTime { get; set; }
        public string BusinessTAN { get; set; }
        public string CKYCNumber { get; set; }
        public string IsRegBussAddrSameAsCurrBussAddr { get; set; }
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
        //     var businessDetails = obj as BusinessDetails;
        //     if (businessDetails?.Id == null || businessDetails?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, businessDetails.Id);
        // }

        //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "BusinessDetails{" +
                    //   $"ID='{Id}'" +
                    $", CompanyName='{CompanyName}'" +
                    $", TradingName='{TradingName}'" +
                    $", BusinessNatureId='{BusinessNatureId}'" +
                    $", IndustryId='{IndustryId}'" +
                    $", SubIndustryId='{SubIndustryId}'" +
                    $", PremisesTypeId='{PremisesTypeId}'" +
                    $", AreaOfShop='{AreaOfShop}'" +
                    $", DoingBusinessSince='{DoingBusinessSince}'" +
                    $", PAN='{PAN}'" +
                    $", TAN='{TAN}'" +
                    $", WebAddress='{WebAddress}'" +
                    $", WeeklyOff='{WeeklyOff}'" +
                    $", OccupiedSince='{OccupiedSince}'" +
                    $", CashSales='{CashSales}'" +
                    $", CardSales='{CardSales}'" +
                    $", ModeOfCommunicationId='{ModeOfCommunicationId}'" +
                    $", RelationId='{RelationId}'" +
                    $", ContactPersonFirstName='{ContactPersonFirstName}'" +
                    $", ContactPersonMiddleName='{ContactPersonMiddleName}'" +
                    $", ContactPersonLastName='{ContactPersonLastName}'" +
                    $", ContactPersonDesignation='{ContactPersonDesignation}'" +
                    $", ContactPersonTitleID='{ContactPersonTitleID}'" +
                    $", AssociatedBusinessIds='{AssociatedBusinessIds}'" +
                    $", Businessflag='{Businessflag}'" +
                    $", UserId='{UserId}'" +
                    $", ControlProgram='{ControlProgram}'" +
                    $", SubSupplierId='{SubSupplierId}'" +
                    $", DealerCode='{DealerCode}'" +
                    $", OMCName='{OMCName}'" +
                    $", CompanyNameAsPerNSDL='{CompanyNameAsPerNSDL}'" +
                    $", NSDLStatus='{NSDLStatus}'" +
                    $", Verified='{Verified}'" +
                    $", IsAnyOtherBusinessEntity='{IsAnyOtherBusinessEntity}'" +
                    $", UdhyogAadharNumber='{UdhyogAadharNumber}'" +
                    $", PreferredAddress='{PreferredAddress}'" +
                    $", EmailID='{EmailID}'" +
                    $", MeetingTime='{MeetingTime}'" +
                    $", BusinessTAN='{BusinessTAN}'" +
                    $", CKYCNumber='{CKYCNumber}'" +
                    $", IsRegBussAddrSameAsCurrBussAddr='{IsRegBussAddrSameAsCurrBussAddr}'" +
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
