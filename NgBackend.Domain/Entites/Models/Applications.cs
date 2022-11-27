using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NgBackend.Domain.Entites.Models
{
    [Table("applications")]
    public class Applications 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long? AppLeadId { get; set; }
        public string ODLimitsId { get; set; }
        public string BusinessAddressId { get; set; }
        public int? CustomerBankInfoId { get; set; }
        public string AppBusinessId { get; set; }
        public string FinanceDetailsId { get; set; }
        public int? EdcTerminalId { get; set; }
        public string IsTerminated { get; set; }
        public int? BusinessRegisteredId { get; set; }
        public int? ApplicationReferenceId { get; set; }
        public int? LitigationId { get; set; }
        public int? BusinessEntityTypeId { get; set; }
        public int? SchemeId { get; set; }
        public long? ApplicationID { get; set; }
        [Required]
        public string LeadId { get; set; }
        public string IsClose { get; set; }
        public string RenewalId { get; set; }
        public int? AgentId { get; set; }
        public long? RenewalfromApplicationId { get; set; }
        public string IsApplicationRenewal { get; set; }
        public string IsDocumnetMissing { get; set; }
        public string IsPermanentRejected { get; set; }
        public long? AppFormId { get; set; }
        public int? IndustryId { get; set; }
        public int? SubIndustryId { get; set; }
        public int? BranchId { get; set; }
        public string XxxContacts { get; set; }
        public int? ContactsId { get; set; }
        public int? ContactTypeId { get; set; }
        public int? TitleID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
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
        public int? ModeOfCommunicationId { get; set; }
        public int? CIBILScore { get; set; }
        public int? ExperianScore { get; set; }
        public int? EquifaxScore { get; set; }
        public string PassportNumber { get; set; }
        public string VoterID { get; set; }
        public string AdharID { get; set; }
        public int? AddressTypeId { get; set; }
        public long? ContactAdressId { get; set; }
        public string Street { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? Pincode { get; set; }
        public string ContactNumber { get; set; }
        public long? ContactNumberId { get; set; }
        public int? NumberTypeId { get; set; }
        public string XxxLoanDetails { get; set; }
        public int? LeadStatusId { get; set; }
        public int? LoanDetailsId { get; set; }
        public int? ProductFamilyId { get; set; }
        public int? ProductId { get; set; }
        public long? LoanAppliedFor { get; set; }
        public int? PurposeOfLoanId { get; set; }
        public int? LoanUtilizationId { get; set; }
        public int? Tenure { get; set; }
        public int? InternalSalesUserID { get; set; }
        public long? ExternalSalesUserID { get; set; }
        public int? SourceBranchID { get; set; }
        public int? LeadSourceId { get; set; }
        public string SourceDetail { get; set; }
        public string Remarks { get; set; }
        public int? DealNumber { get; set; }
        public string IsRenewal { get; set; }
        public string AVPSales { get; set; }
        public string XxxBusinessDetails { get; set; }
        public long? BusinessId { get; set; }
        public string CompanyName { get; set; }
        public string TradingName { get; set; }
        public int? BusinessNatureId { get; set; }
        public int? SubIndustryId1 { get; set; }
        public int? PremisesTypeId { get; set; }
        public int? AreaOfShop { get; set; }
        public DateTime DoingBusinessSince { get; set; }
        public string PAN { get; set; }
        public string TAN { get; set; }
        public string WebAddress { get; set; }
        public string XxxBanking { get; set; }
        public int? MerchantBankInfoId { get; set; }
        public int? BankId { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public int? MICR { get; set; }
        public string IFSC { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int? AccountTypeId { get; set; }
        public int? ECS { get; set; }
        public int? UserNumber { get; set; }
        public string UserName { get; set; }
        public string LedgerFolioNumber { get; set; }
        public long? UserCreditLimit { get; set; }
        public string UserCreditReference { get; set; }
        public int? Sequence { get; set; }
        public string EscrowAccountNumber { get; set; }
        public string EscrowAccountName { get; set; }
        public int? EscrowBankId { get; set; }
        public string EscrowBranchName { get; set; }
        public DateTime? AccountCreatedSince { get; set; }
        public int? NumberOfAccounts { get; set; }
        public string XxxFinance { get; set; }
        public int? NumberOfOpenLoans { get; set; }
        public int? NumberCashCreditODAccounts { get; set; }
        public long? TotalLoanAmount { get; set; }
        public long? ExistingLoanAmount { get; set; }
        public long? CreditODLimit { get; set; }
        public long? TotalBalanceAmount { get; set; }
        public long? TotalLoanBalance { get; set; }
        public long? TotalCreditODOutstanding { get; set; }
        public string SecurityOffered { get; set; }
        public string XxxProcessor { get; set; }
        public int? NumberOfProcessors { get; set; }
        public int? NumberOfMIDs { get; set; }
        public int? NumberOfActiveProcessors { get; set; }
        public int? NumberOfActiveMIDs { get; set; }
        public int? DaysWithCurrentProcessor { get; set; }
        public string XxxCompliance { get; set; }
        public string IsAnyLitigation { get; set; }
        public string XxxAgent { get; set; }
        public int? InternalAgentId { get; set; }
        public int? ExternalAgentId { get; set; }
        public string SalesChecklistRemark { get; set; }
        public string SalesChecklistCompletedBy { get; set; }
        public DateTime SalesChecklistCompletedOn { get; set; }
        public string UnderwritingChecklistRemark { get; set; }
        public string UnderwritingChecklistCompletedBy { get; set; }
        public DateTime UnderwritingChecklistCompletedOn { get; set; }
        public string FundingChecklistRemark { get; set; }
        public string FundingChecklistCompletedBy { get; set; }
        public DateTime FundingChecklistCompletedOn { get; set; }
        public string ConcurrentAuditorRemark { get; set; }
        public string ConcurrentAuditorCompletedBy { get; set; }
        public DateTime ConcurrentAuditorCompletedOn { get; set; }
        public string DocsMissing { get; set; }
        public string DocsUnauthorized { get; set; }
        public string DocsUploaded { get; set; }
        public string DocsAuthorized { get; set; }
        public int? ScoreCIBIL { get; set; }
        public int? ScoreExperian { get; set; }
        public int? ScoreEquifax { get; set; }
        public string VerificationStatus { get; set; }
        public string VerificationCompletedBy { get; set; }
        public DateTime VerificationCompletedOn { get; set; }
        public int? MerchantScoringTotal { get; set; }
        public string MerchantScoringProfile { get; set; }
        public string UWDecision { get; set; }
        public string UWReasons { get; set; }
        public string UWDecisionBy { get; set; }
        public DateTime UWDecisionOn { get; set; }
        public string UWFinalDecision { get; set; }
        public string ContactPersonFullName { get; set; }
        public string ContactPersonFatherFullName { get; set; }
        public string FormNumber { get; set; }
        public int? RegionId { get; set; }
        public int? DSACodeId { get; set; }
        public string PurposeOfLoanPleaseSpecify { get; set; }
        public int? TypeOfBusinessId { get; set; }
        public string UserId { get; set; }
        public string ProcessorNames { get; set; }
        public string MID { get; set; }
        public string TID { get; set; }
        public long? BusinessAdressId { get; set; }
        public string BusinessStreet { get; set; }
        public int? BusinessCityId { get; set; }
        public int? BusinessStateId { get; set; }
        public int? BusinessCountryId { get; set; }
        public int? BusinessPincode { get; set; }
        public string BusinessContactNumber { get; set; }
        public long? BusinessContactNumberId { get; set; }
        public int? BusinessNumberTypeId { get; set; }
        public string IsDraft { get; set; }
        public string MerchantActivationRemark { get; set; }
        public DateTime MerchantActivationDate { get; set; }
        public int? BussinessContactsId { get; set; }
        public string BussinessContactsName { get; set; }
        public string InternalAgentEmail { get; set; }
        public string ExternalAgentEmail { get; set; }
        public string StreetPermanent { get; set; }
        public int? CityIdPermanent { get; set; }
        public int? StateIdPermanent { get; set; }
        public int? CountryIdPermanent { get; set; }
        public int? PincodePermanent { get; set; }
        public string SourceType { get; set; }
        public string BusinessUnit { get; set; }
        public string SalesUserType { get; set; }
        public string ControlProgram { get; set; }
        public int? SubSupplierId { get; set; }
        public string DealerCode { get; set; }
        public string OMCName { get; set; }
        public string MisView { get; set; }
        public string ApplicantPoliticallyApproved { get; set; }
        public string ApplicantRelatedToDirectorNG { get; set; }
        public int? BusinessRegisteredAs { get; set; }
        public string UdhyogAadharNumber { get; set; }
        public string LoanUtilizationOtherValue { get; set; }
        public string BusinessEntityAnyOtherValue { get; set; }
        public int? Scheme { get; set; }
        public int? MoratoriumInDays { get; set; }
        public int? NGDirectorId { get; set; }
        public string RelationshipWithDirector { get; set; }
        public string RelationIfOther { get; set; }
        public int? BusinessStatus { get; set; }
        public string COSRebookingType { get; set; }
        public int? IsNewAPRReported { get; set; }
        public int? RepayMechId { get; set; }
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
        //     var applications = obj as Applications;
        //     if (applications?.Id == null || applications?.Id == 0 || Id == 0) return false;
        //     return EqualityComparer<long>.Default.Equals(Id, applications.Id);
        // }

      //public override int GetHashCode()
        // {
        //     return HashCode.Combine(Id);
        // }

        public override string ToString()
        {
            return "Applications{" +
                 //   $"ID='{Id}'" +
                    $", AppLeadId='{AppLeadId}'" +
                    $", ODLimitsId='{ODLimitsId}'" +
                    $", BusinessAddressId='{BusinessAddressId}'" +
                    $", CustomerBankInfoId='{CustomerBankInfoId}'" +
                    $", AppBusinessId='{AppBusinessId}'" +
                    $", FinanceDetailsId='{FinanceDetailsId}'" +
                    $", EdcTerminalId='{EdcTerminalId}'" +
                    $", IsTerminated='{IsTerminated}'" +
                    $", BusinessRegisteredId='{BusinessRegisteredId}'" +
                    $", ApplicationReferenceId='{ApplicationReferenceId}'" +
                    $", LitigationId='{LitigationId}'" +
                    $", BusinessEntityTypeId='{BusinessEntityTypeId}'" +
                    $", SchemeId='{SchemeId}'" +
                    $", ApplicationID='{ApplicationID}'" +
                    $", LeadId='{LeadId}'" +
                    $", IsClose='{IsClose}'" +
                    $", RenewalId='{RenewalId}'" +
                    $", AgentId='{AgentId}'" +
                    $", RenewalfromApplicationId='{RenewalfromApplicationId}'" +
                    $", IsApplicationRenewal='{IsApplicationRenewal}'" +
                    $", IsDocumnetMissing='{IsDocumnetMissing}'" +
                    $", IsPermanentRejected='{IsPermanentRejected}'" +
                    $", AppFormId='{AppFormId}'" +
                    $", IndustryId='{IndustryId}'" +
                    $", SubIndustryId='{SubIndustryId}'" +
                    $", BranchId='{BranchId}'" +
                    $", XxxContacts='{XxxContacts}'" +
                    $", ContactsId='{ContactsId}'" +
                    $", ContactTypeId='{ContactTypeId}'" +
                    $", TitleID='{TitleID}'" +
                    $", FirstName='{FirstName}'" +
                    $", MiddleName='{MiddleName}'" +
                    $", LastName='{LastName}'" +
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
                    $", ModeOfCommunicationId='{ModeOfCommunicationId}'" +
                    $", CIBILScore='{CIBILScore}'" +
                    $", ExperianScore='{ExperianScore}'" +
                    $", EquifaxScore='{EquifaxScore}'" +
                    $", PassportNumber='{PassportNumber}'" +
                    $", VoterID='{VoterID}'" +
                    $", AdharID='{AdharID}'" +
                    $", AddressTypeId='{AddressTypeId}'" +
                    $", ContactAdressId='{ContactAdressId}'" +
                    $", Street='{Street}'" +
                    $", CityId='{CityId}'" +
                    $", StateId='{StateId}'" +
                    $", CountryId='{CountryId}'" +
                    $", Pincode='{Pincode}'" +
                    $", ContactNumber='{ContactNumber}'" +
                    $", ContactNumberId='{ContactNumberId}'" +
                    $", NumberTypeId='{NumberTypeId}'" +
                    $", XxxLoanDetails='{XxxLoanDetails}'" +
                    $", LeadStatusId='{LeadStatusId}'" +
                    $", LoanDetailsId='{LoanDetailsId}'" +
                    $", ProductFamilyId='{ProductFamilyId}'" +
                    $", ProductId='{ProductId}'" +
                    $", LoanAppliedFor='{LoanAppliedFor}'" +
                    $", PurposeOfLoanId='{PurposeOfLoanId}'" +
                    $", LoanUtilizationId='{LoanUtilizationId}'" +
                    $", Tenure='{Tenure}'" +
                    $", InternalSalesUserID='{InternalSalesUserID}'" +
                    $", ExternalSalesUserID='{ExternalSalesUserID}'" +
                    $", SourceBranchID='{SourceBranchID}'" +
                    $", LeadSourceId='{LeadSourceId}'" +
                    $", SourceDetail='{SourceDetail}'" +
                    $", Remarks='{Remarks}'" +
                    $", DealNumber='{DealNumber}'" +
                    $", IsRenewal='{IsRenewal}'" +
                    $", AVPSales='{AVPSales}'" +
                    $", XxxBusinessDetails='{XxxBusinessDetails}'" +
                    $", BusinessId='{BusinessId}'" +
                    $", CompanyName='{CompanyName}'" +
                    $", TradingName='{TradingName}'" +
                    $", BusinessNatureId='{BusinessNatureId}'" +
                    $", SubIndustryId1='{SubIndustryId1}'" +
                    $", PremisesTypeId='{PremisesTypeId}'" +
                    $", AreaOfShop='{AreaOfShop}'" +
                    $", DoingBusinessSince='{DoingBusinessSince}'" +
                    $", PAN='{PAN}'" +
                    $", TAN='{TAN}'" +
                    $", WebAddress='{WebAddress}'" +
                    $", XxxBanking='{XxxBanking}'" +
                    $", MerchantBankInfoId='{MerchantBankInfoId}'" +
                    $", BankId='{BankId}'" +
                    $", BranchName='{BranchName}'" +
                    $", Address='{Address}'" +
                    $", MICR='{MICR}'" +
                    $", IFSC='{IFSC}'" +
                    $", AccountNumber='{AccountNumber}'" +
                    $", AccountName='{AccountName}'" +
                    $", AccountTypeId='{AccountTypeId}'" +
                    $", ECS='{ECS}'" +
                    $", UserNumber='{UserNumber}'" +
                    $", UserName='{UserName}'" +
                    $", LedgerFolioNumber='{LedgerFolioNumber}'" +
                    $", UserCreditLimit='{UserCreditLimit}'" +
                    $", UserCreditReference='{UserCreditReference}'" +
                    $", Sequence='{Sequence}'" +
                    $", EscrowAccountNumber='{EscrowAccountNumber}'" +
                    $", EscrowAccountName='{EscrowAccountName}'" +
                    $", EscrowBankId='{EscrowBankId}'" +
                    $", EscrowBranchName='{EscrowBranchName}'" +
                    $", AccountCreatedSince='{AccountCreatedSince}'" +
                    $", NumberOfAccounts='{NumberOfAccounts}'" +
                    $", XxxFinance='{XxxFinance}'" +
                    $", NumberOfOpenLoans='{NumberOfOpenLoans}'" +
                    $", NumberCashCreditODAccounts='{NumberCashCreditODAccounts}'" +
                    $", TotalLoanAmount='{TotalLoanAmount}'" +
                    $", ExistingLoanAmount='{ExistingLoanAmount}'" +
                    $", CreditODLimit='{CreditODLimit}'" +
                    $", TotalBalanceAmount='{TotalBalanceAmount}'" +
                    $", TotalLoanBalance='{TotalLoanBalance}'" +
                    $", TotalCreditODOutstanding='{TotalCreditODOutstanding}'" +
                    $", SecurityOffered='{SecurityOffered}'" +
                    $", XxxProcessor='{XxxProcessor}'" +
                    $", NumberOfProcessors='{NumberOfProcessors}'" +
                    $", NumberOfMIDs='{NumberOfMIDs}'" +
                    $", NumberOfActiveProcessors='{NumberOfActiveProcessors}'" +
                    $", NumberOfActiveMIDs='{NumberOfActiveMIDs}'" +
                    $", DaysWithCurrentProcessor='{DaysWithCurrentProcessor}'" +
                    $", XxxCompliance='{XxxCompliance}'" +
                    $", IsAnyLitigation='{IsAnyLitigation}'" +
                    $", XxxAgent='{XxxAgent}'" +
                    $", InternalAgentId='{InternalAgentId}'" +
                    $", ExternalAgentId='{ExternalAgentId}'" +
                    $", SalesChecklistRemark='{SalesChecklistRemark}'" +
                    $", SalesChecklistCompletedBy='{SalesChecklistCompletedBy}'" +
                    $", SalesChecklistCompletedOn='{SalesChecklistCompletedOn}'" +
                    $", UnderwritingChecklistRemark='{UnderwritingChecklistRemark}'" +
                    $", UnderwritingChecklistCompletedBy='{UnderwritingChecklistCompletedBy}'" +
                    $", UnderwritingChecklistCompletedOn='{UnderwritingChecklistCompletedOn}'" +
                    $", FundingChecklistRemark='{FundingChecklistRemark}'" +
                    $", FundingChecklistCompletedBy='{FundingChecklistCompletedBy}'" +
                    $", FundingChecklistCompletedOn='{FundingChecklistCompletedOn}'" +
                    $", ConcurrentAuditorRemark='{ConcurrentAuditorRemark}'" +
                    $", ConcurrentAuditorCompletedBy='{ConcurrentAuditorCompletedBy}'" +
                    $", ConcurrentAuditorCompletedOn='{ConcurrentAuditorCompletedOn}'" +
                    $", DocsMissing='{DocsMissing}'" +
                    $", DocsUnauthorized='{DocsUnauthorized}'" +
                    $", DocsUploaded='{DocsUploaded}'" +
                    $", DocsAuthorized='{DocsAuthorized}'" +
                    $", ScoreCIBIL='{ScoreCIBIL}'" +
                    $", ScoreExperian='{ScoreExperian}'" +
                    $", ScoreEquifax='{ScoreEquifax}'" +
                    $", VerificationStatus='{VerificationStatus}'" +
                    $", VerificationCompletedBy='{VerificationCompletedBy}'" +
                    $", VerificationCompletedOn='{VerificationCompletedOn}'" +
                    $", MerchantScoringTotal='{MerchantScoringTotal}'" +
                    $", MerchantScoringProfile='{MerchantScoringProfile}'" +
                    $", UWDecision='{UWDecision}'" +
                    $", UWReasons='{UWReasons}'" +
                    $", UWDecisionBy='{UWDecisionBy}'" +
                    $", UWDecisionOn='{UWDecisionOn}'" +
                    $", UWFinalDecision='{UWFinalDecision}'" +
                    $", ContactPersonFullName='{ContactPersonFullName}'" +
                    $", ContactPersonFatherFullName='{ContactPersonFatherFullName}'" +
                    $", FormNumber='{FormNumber}'" +
                    $", RegionId='{RegionId}'" +
                    $", DSACodeId='{DSACodeId}'" +
                    $", PurposeOfLoanPleaseSpecify='{PurposeOfLoanPleaseSpecify}'" +
                    $", TypeOfBusinessId='{TypeOfBusinessId}'" +
                    $", UserId='{UserId}'" +
                    $", ProcessorNames='{ProcessorNames}'" +
                    $", MID='{MID}'" +
                    $", TID='{TID}'" +
                    $", BusinessAdressId='{BusinessAdressId}'" +
                    $", BusinessStreet='{BusinessStreet}'" +
                    $", BusinessCityId='{BusinessCityId}'" +
                    $", BusinessStateId='{BusinessStateId}'" +
                    $", BusinessCountryId='{BusinessCountryId}'" +
                    $", BusinessPincode='{BusinessPincode}'" +
                    $", BusinessContactNumber='{BusinessContactNumber}'" +
                    $", BusinessContactNumberId='{BusinessContactNumberId}'" +
                    $", BusinessNumberTypeId='{BusinessNumberTypeId}'" +
                    $", IsDraft='{IsDraft}'" +
                    $", MerchantActivationRemark='{MerchantActivationRemark}'" +
                    $", MerchantActivationDate='{MerchantActivationDate}'" +
                    $", BussinessContactsId='{BussinessContactsId}'" +
                    $", BussinessContactsName='{BussinessContactsName}'" +
                    $", InternalAgentEmail='{InternalAgentEmail}'" +
                    $", ExternalAgentEmail='{ExternalAgentEmail}'" +
                    $", StreetPermanent='{StreetPermanent}'" +
                    $", CityIdPermanent='{CityIdPermanent}'" +
                    $", StateIdPermanent='{StateIdPermanent}'" +
                    $", CountryIdPermanent='{CountryIdPermanent}'" +
                    $", PincodePermanent='{PincodePermanent}'" +
                    $", SourceType='{SourceType}'" +
                    $", BusinessUnit='{BusinessUnit}'" +
                    $", SalesUserType='{SalesUserType}'" +
                    $", ControlProgram='{ControlProgram}'" +
                    $", SubSupplierId='{SubSupplierId}'" +
                    $", DealerCode='{DealerCode}'" +
                    $", OMCName='{OMCName}'" +
                    $", MisView='{MisView}'" +
                    $", ApplicantPoliticallyApproved='{ApplicantPoliticallyApproved}'" +
                    $", ApplicantRelatedToDirectorNG='{ApplicantRelatedToDirectorNG}'" +
                    $", BusinessRegisteredAs='{BusinessRegisteredAs}'" +
                    $", UdhyogAadharNumber='{UdhyogAadharNumber}'" +
                    $", LoanUtilizationOtherValue='{LoanUtilizationOtherValue}'" +
                    $", BusinessEntityAnyOtherValue='{BusinessEntityAnyOtherValue}'" +
                    $", Scheme='{Scheme}'" +
                    $", MoratoriumInDays='{MoratoriumInDays}'" +
                    $", NGDirectorId='{NGDirectorId}'" +
                    $", RelationshipWithDirector='{RelationshipWithDirector}'" +
                    $", RelationIfOther='{RelationIfOther}'" +
                    $", BusinessStatus='{BusinessStatus}'" +
                    $", COSRebookingType='{COSRebookingType}'" +
                    $", IsNewAPRReported='{IsNewAPRReported}'" +
                    $", RepayMechId='{RepayMechId}'" +
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
