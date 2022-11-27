using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("contacts")]
    public class Contacts 
    {
        public long? ContactsId {get; set;}
        public int? TitleID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PANNo { get; set; }
        public string EmailId { get; set; }
        public string DinNo { get; set; }
        public int? NoOfSharesHeldWith { get; set; }
        public string Designation { get; set; }
        public int? FathersTitleID { get; set; }
        public string FathersFirstName { get; set; }
        public string FathersMiddleName { get; set; }
        public string FathersLastName { get; set; }
        public string WeeklyOff { get; set; }
        public DateTime BirthDate { get; set; }
        public int? Shareholding { get; set; }
        public string Gender { get; set; }
        public int? ContactSequenceId { get; set; }
        public int? EducationTypeId { get; set; }
        public string DPINNo { get; set; }
        public int? PercentPartnership { get; set; }
        public int? RelationId { get; set; }
        public int? EmploymentStatusId { get; set; }
        public string EmploymentCompany { get; set; }
        public int? EmploymentConstitutionId { get; set; }
        public int? EmploymentPercentProfit { get; set; }
        public int? EmploymentPercentageShareholding { get; set; }
        public int? EmploymentBusinessNatureId { get; set; }
        public int? EmploymentIndustryId { get; set; }
        public int? EmploymentSubIndustryId { get; set; }
        public int? EmploymentBusinessPremisesTypeId { get; set; }
        public int? EmploymentAreaOfStore { get; set; }
        public DateTime EmploymentDoingBusinessSince { get; set; }
        public string EmploymentPAN { get; set; }
        public string EmploymentWebAddress { get; set; }
        public string SalariedNameOfEmployer { get; set; }
        public DateTime SalariedWorkingSince { get; set; }
        public int? ModeOfCommunicationId { get; set; }
        public int? CIBILScore { get; set; }
        public int? ExperianScore { get; set; }
        public int? EquifaxScore { get; set; }
        public string PassportNumber { get; set; }
        public string VoterID { get; set; }
        public string AdharID { get; set; }
        public DateTime ResidingSince { get; set; }
        public int? ResidentialPremisesTypeId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int? ExportDataId { get; set; }
        public int? TmpLeadId { get; set; }
        public string FirstNameAsPerNSDL { get; set; }
        public string MiddleNameAsPerNSDL { get; set; }
        public string LastNameAsPerNSDL { get; set; }
        public int? NSDLStatus { get; set; }
        public string Verified { get; set; }
        public string MothersMaidenName { get; set; }
        public int? MaritalStatus { get; set; }
        public int? OccupationType { get; set; }
        public int? PreferredAddress { get; set; }
        public string EducationTypeOther { get; set; }
        public string CKYCNumber { get; set; }
        public string IsPerAddrSameAsResAddr { get; set; }
        public long? ApplicantDocsFileId { get; set; }
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
        //     var contacts = obj as Contacts;
        //     if (contacts?.Id == null || contacts?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, contacts.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "Contacts{" +
                 //   $"ID='{Id}'" +
                    $", TitleID='{TitleID}'" +
                    $", FirstName='{FirstName}'" +
                    $", MiddleName='{MiddleName}'" +
                    $", LastName='{LastName}'" +
                    $", PANNo='{PANNo}'" +
                    $", EmailId='{EmailId}'" +
                    $", DinNo='{DinNo}'" +
                    $", NoOfSharesHeldWith='{NoOfSharesHeldWith}'" +
                    $", Designation='{Designation}'" +
                    $", FathersTitleID='{FathersTitleID}'" +
                    $", FathersFirstName='{FathersFirstName}'" +
                    $", FathersMiddleName='{FathersMiddleName}'" +
                    $", FathersLastName='{FathersLastName}'" +
                    $", WeeklyOff='{WeeklyOff}'" +
                    $", BirthDate='{BirthDate}'" +
                    $", Shareholding='{Shareholding}'" +
                    $", Gender='{Gender}'" +
                    $", ContactSequenceId='{ContactSequenceId}'" +
                    $", EducationTypeId='{EducationTypeId}'" +
                    $", DPINNo='{DPINNo}'" +
                    $", PercentPartnership='{PercentPartnership}'" +
                    $", RelationId='{RelationId}'" +
                    $", EmploymentStatusId='{EmploymentStatusId}'" +
                    $", EmploymentCompany='{EmploymentCompany}'" +
                    $", EmploymentConstitutionId='{EmploymentConstitutionId}'" +
                    $", EmploymentPercentProfit='{EmploymentPercentProfit}'" +
                    $", EmploymentPercentageShareholding='{EmploymentPercentageShareholding}'" +
                    $", EmploymentBusinessNatureId='{EmploymentBusinessNatureId}'" +
                    $", EmploymentIndustryId='{EmploymentIndustryId}'" +
                    $", EmploymentSubIndustryId='{EmploymentSubIndustryId}'" +
                    $", EmploymentBusinessPremisesTypeId='{EmploymentBusinessPremisesTypeId}'" +
                    $", EmploymentAreaOfStore='{EmploymentAreaOfStore}'" +
                    $", EmploymentDoingBusinessSince='{EmploymentDoingBusinessSince}'" +
                    $", EmploymentPAN='{EmploymentPAN}'" +
                    $", EmploymentWebAddress='{EmploymentWebAddress}'" +
                    $", SalariedNameOfEmployer='{SalariedNameOfEmployer}'" +
                    $", SalariedWorkingSince='{SalariedWorkingSince}'" +
                    $", ModeOfCommunicationId='{ModeOfCommunicationId}'" +
                    $", CIBILScore='{CIBILScore}'" +
                    $", ExperianScore='{ExperianScore}'" +
                    $", EquifaxScore='{EquifaxScore}'" +
                    $", PassportNumber='{PassportNumber}'" +
                    $", VoterID='{VoterID}'" +
                    $", AdharID='{AdharID}'" +
                    $", ResidingSince='{ResidingSince}'" +
                    $", ResidentialPremisesTypeId='{ResidentialPremisesTypeId}'" +
                    $", Name='{Name}'" +
                    $", FatherName='{FatherName}'" +
                    $", ExportDataId='{ExportDataId}'" +
                    $", TmpLeadId='{TmpLeadId}'" +
                    $", FirstNameAsPerNSDL='{FirstNameAsPerNSDL}'" +
                    $", MiddleNameAsPerNSDL='{MiddleNameAsPerNSDL}'" +
                    $", LastNameAsPerNSDL='{LastNameAsPerNSDL}'" +
                    $", NSDLStatus='{NSDLStatus}'" +
                    $", Verified='{Verified}'" +
                    $", MothersMaidenName='{MothersMaidenName}'" +
                    $", MaritalStatus='{MaritalStatus}'" +
                    $", OccupationType='{OccupationType}'" +
                    $", PreferredAddress='{PreferredAddress}'" +
                    $", EducationTypeOther='{EducationTypeOther}'" +
                    $", CKYCNumber='{CKYCNumber}'" +
                    $", IsPerAddrSameAsResAddr='{IsPerAddrSameAsResAddr}'" +
                    $", ApplicantDocsFileId='{ApplicantDocsFileId}'" +
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
