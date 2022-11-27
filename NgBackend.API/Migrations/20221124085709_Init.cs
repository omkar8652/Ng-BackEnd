using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NgBackend.API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "application_business",
                columns: table => new
                {
                    ApplicationBusinessId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<int>(type: "int", nullable: true),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_business", x => x.ApplicationBusinessId);
                });

            migrationBuilder.CreateTable(
                name: "application_cash_credit_litigation",
                columns: table => new
                {
                    LitigationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCaseFiling = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LitigationTypeId = table.Column<int>(type: "int", nullable: true),
                    PendingWithAuthority = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaintiff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Defendant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountInvolved = table.Column<long>(type: "bigint", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_cash_credit_litigation", x => x.LitigationId);
                });

            migrationBuilder.CreateTable(
                name: "application_cash_credit_od_limits",
                columns: table => new
                {
                    ODLimitsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfInstitution = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfFacility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SanctionedAmount = table.Column<long>(type: "bigint", nullable: true),
                    PresentOutstanding = table.Column<long>(type: "bigint", nullable: true),
                    SecurityOffered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_cash_credit_od_limits", x => x.ODLimitsId);
                });

            migrationBuilder.CreateTable(
                name: "application_contacts",
                columns: table => new
                {
                    ApplicationContactsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactsId = table.Column<int>(type: "int", nullable: true),
                    ContactTypeId = table.Column<int>(type: "int", nullable: true),
                    LeadId = table.Column<long>(type: "bigint", nullable: true),
                    ApplicationID = table.Column<long>(type: "bigint", nullable: true),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVideoKYCApplicable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoKYCCurrentStatus = table.Column<int>(type: "int", nullable: true),
                    VkycIdentifier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_contacts", x => x.ApplicationContactsId);
                });

            migrationBuilder.CreateTable(
                name: "application_existing_loans",
                columns: table => new
                {
                    ApplicationExistingLoansId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FinancierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanTypeId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<long>(type: "bigint", nullable: true),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthlyEMI = table.Column<long>(type: "bigint", nullable: true),
                    TenureInMonths = table.Column<int>(type: "int", nullable: true),
                    Balance = table.Column<long>(type: "bigint", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_existing_loans", x => x.ApplicationExistingLoansId);
                });

            migrationBuilder.CreateTable(
                name: "application_purpose_of_loan",
                columns: table => new
                {
                    ApplicationPurposeOfLoanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurposeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_purpose_of_loan", x => x.ApplicationPurposeOfLoanId);
                });

            migrationBuilder.CreateTable(
                name: "application_reference",
                columns: table => new
                {
                    ApplicationReferenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationReferenceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    RelationId = table.Column<int>(type: "int", nullable: true),
                    NumberTypeId = table.Column<int>(type: "int", nullable: true),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_reference", x => x.ApplicationReferenceId);
                });

            migrationBuilder.CreateTable(
                name: "applications",
                columns: table => new
                {
                    AppLeadId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ODLimitsId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAddressId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerBankInfoId = table.Column<int>(type: "int", nullable: true),
                    AppBusinessId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinanceDetailsId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EdcTerminalId = table.Column<int>(type: "int", nullable: true),
                    IsTerminated = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessRegisteredId = table.Column<int>(type: "int", nullable: true),
                    ApplicationReferenceId = table.Column<int>(type: "int", nullable: true),
                    LitigationId = table.Column<int>(type: "int", nullable: true),
                    BusinessEntityTypeId = table.Column<int>(type: "int", nullable: true),
                    SchemeId = table.Column<int>(type: "int", nullable: true),
                    ApplicationID = table.Column<long>(type: "bigint", nullable: true),
                    IsClose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RenewalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: true),
                    RenewalfromApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    IsApplicationRenewal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDocumnetMissing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPermanentRejected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppFormId = table.Column<long>(type: "bigint", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    SubIndustryId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    XxxContacts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactsId = table.Column<int>(type: "int", nullable: true),
                    ContactTypeId = table.Column<int>(type: "int", nullable: true),
                    TitleID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfSharesHeldWith = table.Column<int>(type: "int", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersTitleID = table.Column<int>(type: "int", nullable: true),
                    FathersFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeeklyOff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shareholding = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactSequenceId = table.Column<int>(type: "int", nullable: true),
                    EducationTypeId = table.Column<int>(type: "int", nullable: true),
                    DPINNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentPartnership = table.Column<int>(type: "int", nullable: true),
                    RelationId = table.Column<int>(type: "int", nullable: true),
                    EmploymentStatusId = table.Column<int>(type: "int", nullable: true),
                    EmploymentCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentConstitutionId = table.Column<int>(type: "int", nullable: true),
                    EmploymentPercentProfit = table.Column<int>(type: "int", nullable: true),
                    EmploymentPercentageShareholding = table.Column<int>(type: "int", nullable: true),
                    EmploymentBusinessNatureId = table.Column<int>(type: "int", nullable: true),
                    EmploymentIndustryId = table.Column<int>(type: "int", nullable: true),
                    EmploymentSubIndustryId = table.Column<int>(type: "int", nullable: true),
                    EmploymentBusinessPremisesTypeId = table.Column<int>(type: "int", nullable: true),
                    EmploymentAreaOfStore = table.Column<int>(type: "int", nullable: true),
                    EmploymentDoingBusinessSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmploymentPAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentWebAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeOfCommunicationId = table.Column<int>(type: "int", nullable: true),
                    CIBILScore = table.Column<int>(type: "int", nullable: true),
                    ExperianScore = table.Column<int>(type: "int", nullable: true),
                    EquifaxScore = table.Column<int>(type: "int", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoterID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdharID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressTypeId = table.Column<int>(type: "int", nullable: true),
                    ContactAdressId = table.Column<long>(type: "bigint", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumberId = table.Column<long>(type: "bigint", nullable: true),
                    NumberTypeId = table.Column<int>(type: "int", nullable: true),
                    XxxLoanDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeadStatusId = table.Column<int>(type: "int", nullable: true),
                    LoanDetailsId = table.Column<int>(type: "int", nullable: true),
                    ProductFamilyId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    LoanAppliedFor = table.Column<long>(type: "bigint", nullable: true),
                    PurposeOfLoanId = table.Column<int>(type: "int", nullable: true),
                    LoanUtilizationId = table.Column<int>(type: "int", nullable: true),
                    Tenure = table.Column<int>(type: "int", nullable: true),
                    InternalSalesUserID = table.Column<int>(type: "int", nullable: true),
                    ExternalSalesUserID = table.Column<long>(type: "bigint", nullable: true),
                    SourceBranchID = table.Column<int>(type: "int", nullable: true),
                    LeadSourceId = table.Column<int>(type: "int", nullable: true),
                    SourceDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DealNumber = table.Column<int>(type: "int", nullable: true),
                    IsRenewal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AVPSales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XxxBusinessDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessNatureId = table.Column<int>(type: "int", nullable: true),
                    SubIndustryId1 = table.Column<int>(type: "int", nullable: true),
                    PremisesTypeId = table.Column<int>(type: "int", nullable: true),
                    AreaOfShop = table.Column<int>(type: "int", nullable: true),
                    DoingBusinessSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XxxBanking = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantBankInfoId = table.Column<int>(type: "int", nullable: true),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MICR = table.Column<int>(type: "int", nullable: true),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: true),
                    ECS = table.Column<int>(type: "int", nullable: true),
                    UserNumber = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerFolioNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreditLimit = table.Column<long>(type: "bigint", nullable: true),
                    UserCreditReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    EscrowAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscrowAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscrowBankId = table.Column<int>(type: "int", nullable: true),
                    EscrowBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountCreatedSince = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfAccounts = table.Column<int>(type: "int", nullable: true),
                    XxxFinance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfOpenLoans = table.Column<int>(type: "int", nullable: true),
                    NumberCashCreditODAccounts = table.Column<int>(type: "int", nullable: true),
                    TotalLoanAmount = table.Column<long>(type: "bigint", nullable: true),
                    ExistingLoanAmount = table.Column<long>(type: "bigint", nullable: true),
                    CreditODLimit = table.Column<long>(type: "bigint", nullable: true),
                    TotalBalanceAmount = table.Column<long>(type: "bigint", nullable: true),
                    TotalLoanBalance = table.Column<long>(type: "bigint", nullable: true),
                    TotalCreditODOutstanding = table.Column<long>(type: "bigint", nullable: true),
                    SecurityOffered = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XxxProcessor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfProcessors = table.Column<int>(type: "int", nullable: true),
                    NumberOfMIDs = table.Column<int>(type: "int", nullable: true),
                    NumberOfActiveProcessors = table.Column<int>(type: "int", nullable: true),
                    NumberOfActiveMIDs = table.Column<int>(type: "int", nullable: true),
                    DaysWithCurrentProcessor = table.Column<int>(type: "int", nullable: true),
                    XxxCompliance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnyLitigation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XxxAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalAgentId = table.Column<int>(type: "int", nullable: true),
                    ExternalAgentId = table.Column<int>(type: "int", nullable: true),
                    SalesChecklistRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesChecklistCompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesChecklistCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnderwritingChecklistRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnderwritingChecklistCompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnderwritingChecklistCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FundingChecklistRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundingChecklistCompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundingChecklistCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConcurrentAuditorRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrentAuditorCompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrentAuditorCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DocsMissing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocsUnauthorized = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocsUploaded = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocsAuthorized = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ScoreCIBIL = table.Column<int>(type: "int", nullable: true),
                    ScoreExperian = table.Column<int>(type: "int", nullable: true),
                    ScoreEquifax = table.Column<int>(type: "int", nullable: true),
                    VerificationStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationCompletedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationCompletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MerchantScoringTotal = table.Column<int>(type: "int", nullable: true),
                    MerchantScoringProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UWDecision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UWReasons = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UWDecisionBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UWDecisionOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UWFinalDecision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonFatherFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: true),
                    DSACodeId = table.Column<int>(type: "int", nullable: true),
                    PurposeOfLoanPleaseSpecify = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfBusinessId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessorNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAdressId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessCityId = table.Column<int>(type: "int", nullable: true),
                    BusinessStateId = table.Column<int>(type: "int", nullable: true),
                    BusinessCountryId = table.Column<int>(type: "int", nullable: true),
                    BusinessPincode = table.Column<int>(type: "int", nullable: true),
                    BusinessContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessContactNumberId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessNumberTypeId = table.Column<int>(type: "int", nullable: true),
                    IsDraft = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantActivationRemark = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MerchantActivationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BussinessContactsId = table.Column<int>(type: "int", nullable: true),
                    BussinessContactsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalAgentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExternalAgentEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetPermanent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityIdPermanent = table.Column<int>(type: "int", nullable: true),
                    StateIdPermanent = table.Column<int>(type: "int", nullable: true),
                    CountryIdPermanent = table.Column<int>(type: "int", nullable: true),
                    PincodePermanent = table.Column<int>(type: "int", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesUserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubSupplierId = table.Column<int>(type: "int", nullable: true),
                    DealerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OMCName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MisView = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantPoliticallyApproved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantRelatedToDirectorNG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessRegisteredAs = table.Column<int>(type: "int", nullable: true),
                    UdhyogAadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoanUtilizationOtherValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessEntityAnyOtherValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scheme = table.Column<int>(type: "int", nullable: true),
                    MoratoriumInDays = table.Column<int>(type: "int", nullable: true),
                    NGDirectorId = table.Column<int>(type: "int", nullable: true),
                    RelationshipWithDirector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelationIfOther = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessStatus = table.Column<int>(type: "int", nullable: true),
                    COSRebookingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsNewAPRReported = table.Column<int>(type: "int", nullable: true),
                    RepayMechId = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applications", x => new { x.AppLeadId, x.LeadId });
                });

            migrationBuilder.CreateTable(
                name: "business_address",
                columns: table => new
                {
                    BusinessAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: true),
                    AddressTypeId = table.Column<int>(type: "int", nullable: true),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Businessflag = table.Column<int>(type: "int", nullable: true),
                    BAddressflag = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressProofId = table.Column<long>(type: "bigint", nullable: true),
                    DocsFIleId = table.Column<long>(type: "bigint", nullable: true),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_address", x => x.BusinessAddressId);
                });

            migrationBuilder.CreateTable(
                name: "business_contact_numbers",
                columns: table => new
                {
                    BusinessContactNumbersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessId = table.Column<long>(type: "bigint", nullable: true),
                    NumberType = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAddressId = table.Column<long>(type: "bigint", nullable: true),
                    Businessflag = table.Column<int>(type: "int", nullable: true),
                    BAddressflag = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationContactAdressId = table.Column<long>(type: "bigint", nullable: true),
                    CAddressflag = table.Column<int>(type: "int", nullable: true),
                    Contactflag = table.Column<int>(type: "int", nullable: true),
                    ApplicationContactsId = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_contact_numbers", x => x.BusinessContactNumbersId);
                });

            migrationBuilder.CreateTable(
                name: "business_details",
                columns: table => new
                {
                    BusinessDetailsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradingName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessNatureId = table.Column<int>(type: "int", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    SubIndustryId = table.Column<int>(type: "int", nullable: true),
                    PremisesTypeId = table.Column<int>(type: "int", nullable: true),
                    AreaOfShop = table.Column<int>(type: "int", nullable: true),
                    DoingBusinessSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeeklyOff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OccupiedSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CashSales = table.Column<long>(type: "bigint", nullable: true),
                    CardSales = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModeOfCommunicationId = table.Column<int>(type: "int", nullable: true),
                    RelationId = table.Column<int>(type: "int", nullable: true),
                    ContactPersonFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonDesignation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonTitleID = table.Column<int>(type: "int", nullable: true),
                    AssociatedBusinessIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Businessflag = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ControlProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubSupplierId = table.Column<int>(type: "int", nullable: true),
                    DealerCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OMCName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyNameAsPerNSDL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSDLStatus = table.Column<int>(type: "int", nullable: true),
                    Verified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnyOtherBusinessEntity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UdhyogAadharNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredAddress = table.Column<int>(type: "int", nullable: true),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeetingTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessTAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CKYCNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRegBussAddrSameAsCurrBussAddr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_details", x => x.BusinessDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "business_nature",
                columns: table => new
                {
                    BusinessNatureId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_business_nature", x => x.BusinessNatureId);
                });

            migrationBuilder.CreateTable(
                name: "contact_address",
                columns: table => new
                {
                    ContactAddressId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactsId = table.Column<int>(type: "int", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: true),
                    AddressTypeId = table.Column<int>(type: "int", nullable: true),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressProofId = table.Column<int>(type: "int", nullable: true),
                    DocsFileId = table.Column<long>(type: "bigint", nullable: true),
                    AddressProofText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_address", x => x.ContactAddressId);
                });

            migrationBuilder.CreateTable(
                name: "contact_mode_of_communication",
                columns: table => new
                {
                    ContactModeOfCommunicationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_mode_of_communication", x => x.ContactModeOfCommunicationId);
                });

            migrationBuilder.CreateTable(
                name: "contact_number_type",
                columns: table => new
                {
                    ContactNumberTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_number_type", x => x.ContactNumberTypeId);
                });

            migrationBuilder.CreateTable(
                name: "contact_numbers",
                columns: table => new
                {
                    ContactNumbersId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactsId = table.Column<int>(type: "int", nullable: true),
                    NumberType = table.Column<int>(type: "int", nullable: true),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAdressId = table.Column<long>(type: "bigint", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_numbers", x => x.ContactNumbersId);
                });

            migrationBuilder.CreateTable(
                name: "contact_relation_with_borrower",
                columns: table => new
                {
                    RelationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact_relation_with_borrower", x => x.RelationId);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    ContactsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleID = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfSharesHeldWith = table.Column<int>(type: "int", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersTitleID = table.Column<int>(type: "int", nullable: true),
                    FathersFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersMiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FathersLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeeklyOff = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Shareholding = table.Column<int>(type: "int", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactSequenceId = table.Column<int>(type: "int", nullable: true),
                    EducationTypeId = table.Column<int>(type: "int", nullable: true),
                    DPINNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentPartnership = table.Column<int>(type: "int", nullable: true),
                    RelationId = table.Column<int>(type: "int", nullable: true),
                    EmploymentStatusId = table.Column<int>(type: "int", nullable: true),
                    EmploymentCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentConstitutionId = table.Column<int>(type: "int", nullable: true),
                    EmploymentPercentProfit = table.Column<int>(type: "int", nullable: true),
                    EmploymentPercentageShareholding = table.Column<int>(type: "int", nullable: true),
                    EmploymentBusinessNatureId = table.Column<int>(type: "int", nullable: true),
                    EmploymentIndustryId = table.Column<int>(type: "int", nullable: true),
                    EmploymentSubIndustryId = table.Column<int>(type: "int", nullable: true),
                    EmploymentBusinessPremisesTypeId = table.Column<int>(type: "int", nullable: true),
                    EmploymentAreaOfStore = table.Column<int>(type: "int", nullable: true),
                    EmploymentDoingBusinessSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmploymentPAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentWebAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalariedNameOfEmployer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalariedWorkingSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModeOfCommunicationId = table.Column<int>(type: "int", nullable: true),
                    CIBILScore = table.Column<int>(type: "int", nullable: true),
                    ExperianScore = table.Column<int>(type: "int", nullable: true),
                    EquifaxScore = table.Column<int>(type: "int", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VoterID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdharID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidingSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResidentialPremisesTypeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExportDataId = table.Column<int>(type: "int", nullable: true),
                    TmpLeadId = table.Column<int>(type: "int", nullable: true),
                    FirstNameAsPerNSDL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleNameAsPerNSDL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastNameAsPerNSDL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NSDLStatus = table.Column<int>(type: "int", nullable: true),
                    Verified = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MothersMaidenName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: true),
                    OccupationType = table.Column<int>(type: "int", nullable: true),
                    PreferredAddress = table.Column<int>(type: "int", nullable: true),
                    EducationTypeOther = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CKYCNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPerAddrSameAsResAddr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantDocsFileId = table.Column<long>(type: "bigint", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.ContactsId);
                });

            migrationBuilder.CreateTable(
                name: "customer_bank_info",
                columns: table => new
                {
                    CustomerBankInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: true),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountOperatedSince = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer_bank_info", x => x.CustomerBankInfoId);
                });

            migrationBuilder.CreateTable(
                name: "gst_detail_info",
                columns: table => new
                {
                    GSTID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GSTIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GSTAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gst_detail_info", x => x.GSTID);
                });

            migrationBuilder.CreateTable(
                name: "gst_master_info",
                columns: table => new
                {
                    GSTID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: true),
                    GSTExcepNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalNoOfGST = table.Column<int>(type: "int", nullable: true),
                    SourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gst_master_info", x => x.GSTID);
                });

            migrationBuilder.CreateTable(
                name: "lead_source",
                columns: table => new
                {
                    LeadSourceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeadSourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    IsAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lead_source", x => x.LeadSourceId);
                });

            migrationBuilder.CreateTable(
                name: "merchant_bank_info",
                columns: table => new
                {
                    MerchantBankInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDefault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MICR = table.Column<int>(type: "int", nullable: true),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: true),
                    ECS = table.Column<int>(type: "int", nullable: true),
                    UserNumber = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerFolioNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreditLimit = table.Column<long>(type: "bigint", nullable: true),
                    UserCreditReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    EscrowAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscrowAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscrowBankId = table.Column<int>(type: "int", nullable: true),
                    EscrowBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataModeFlg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountCreatedSince = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merchant_bank_info", x => x.MerchantBankInfoId);
                });

            migrationBuilder.CreateTable(
                name: "merchant_processors",
                columns: table => new
                {
                    MerchantBankInfoId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDefault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankId = table.Column<int>(type: "int", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MICR = table.Column<int>(type: "int", nullable: true),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: true),
                    ECS = table.Column<int>(type: "int", nullable: true),
                    UserNumber = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LedgerFolioNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreditLimit = table.Column<long>(type: "bigint", nullable: true),
                    UserCreditReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    EscrowAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscrowAccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EscrowBankId = table.Column<int>(type: "int", nullable: true),
                    EscrowBranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataModeFlg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountCreatedSince = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merchant_processors", x => x.MerchantBankInfoId);
                });

            migrationBuilder.CreateTable(
                name: "mst_account_type",
                columns: table => new
                {
                    AccountTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_account_type", x => x.AccountTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressTypeId = table.Column<int>(type: "int", nullable: false),
                    AddressProofId = table.Column<int>(type: "int", nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressSubType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAddressflag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactAddressSubflag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAddressflag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessAddressSubflag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_address", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "mst_address_proof",
                columns: table => new
                {
                    AddressProofId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressProofType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressProofText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_address_proof", x => x.AddressProofId);
                });

            migrationBuilder.CreateTable(
                name: "mst_address_type",
                columns: table => new
                {
                    AddressTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressTypeText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_address_type", x => x.AddressTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_agents",
                columns: table => new
                {
                    AgentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalAgentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExternalAgentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_agents", x => x.AgentId);
                });

            migrationBuilder.CreateTable(
                name: "mst_branch",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_branch", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "mst_business_entity_type",
                columns: table => new
                {
                    BusinessEntityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessEntityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAnyOtherBusinessEntity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_business_entity_type", x => x.BusinessEntityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_business_registered",
                columns: table => new
                {
                    BusinessRegisteredId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessRegisteredAs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_business_registered", x => x.BusinessRegisteredId);
                });

            migrationBuilder.CreateTable(
                name: "mst_business_unit",
                columns: table => new
                {
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_business_unit", x => x.BusinessUnitId);
                });

            migrationBuilder.CreateTable(
                name: "mst_city",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_city", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "mst_control_program",
                columns: table => new
                {
                    ControlProgramId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlProgram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_control_program", x => x.ControlProgramId);
                });

            migrationBuilder.CreateTable(
                name: "mst_country",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_country", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "mst_cust_type",
                columns: table => new
                {
                    CustTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_cust_type", x => x.CustTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_docs_file",
                columns: table => new
                {
                    DocsFIleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocsFIle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_docs_file", x => x.DocsFIleId);
                });

            migrationBuilder.CreateTable(
                name: "mst_dsa",
                columns: table => new
                {
                    DSACodeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DsaCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_dsa", x => x.DSACodeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_edc_terminal",
                columns: table => new
                {
                    EdcTerminalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcquirerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_edc_terminal", x => x.EdcTerminalId);
                });

            migrationBuilder.CreateTable(
                name: "mst_education_type",
                columns: table => new
                {
                    EducationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationTypeOther = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_education_type", x => x.EducationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_external_agents",
                columns: table => new
                {
                    ExternalAgentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalAgentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_external_agents", x => x.ExternalAgentId);
                });

            migrationBuilder.CreateTable(
                name: "mst_industry",
                columns: table => new
                {
                    IndustryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndustryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_industry", x => x.IndustryId);
                });

            migrationBuilder.CreateTable(
                name: "mst_internal_agents",
                columns: table => new
                {
                    InternalAgentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalAgentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_internal_agents", x => x.InternalAgentId);
                });

            migrationBuilder.CreateTable(
                name: "mst_mar_status",
                columns: table => new
                {
                    MaritalStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaritalStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_mar_status", x => x.MaritalStatusId);
                });

            migrationBuilder.CreateTable(
                name: "mst_occupation_type",
                columns: table => new
                {
                    OccupationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OccupationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_occupation_type", x => x.OccupationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_omc",
                columns: table => new
                {
                    OMCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OMCName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_omc", x => x.OMCId);
                });

            migrationBuilder.CreateTable(
                name: "mst_premises_type",
                columns: table => new
                {
                    PremisesTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOwnedType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_premises_type", x => x.PremisesTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_region",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_region", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "mst_scheme",
                columns: table => new
                {
                    SchemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchemeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_scheme", x => x.SchemeId);
                });

            migrationBuilder.CreateTable(
                name: "mst_source",
                columns: table => new
                {
                    SourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_source", x => x.SourceId);
                });

            migrationBuilder.CreateTable(
                name: "mst_state",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_state", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "mst_sub_industry",
                columns: table => new
                {
                    SubIndustryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubIndustryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_sub_industry", x => x.SubIndustryId);
                });

            migrationBuilder.CreateTable(
                name: "mst_titles",
                columns: table => new
                {
                    TitlesId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequence = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_titles", x => x.TitlesId);
                });

            migrationBuilder.CreateTable(
                name: "mst_user",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mst_user", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ng_directors_matrix",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfInactive = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ng_directors_matrix", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "repay_mechanism_master",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickType = table.Column<int>(type: "int", nullable: true),
                    PickUpValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PickUpId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_repay_mechanism_master", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "utility_master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsValid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherVal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UUID = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Version = table.Column<double>(type: "float", nullable: true),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utility_master", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "application_business");

            migrationBuilder.DropTable(
                name: "application_cash_credit_litigation");

            migrationBuilder.DropTable(
                name: "application_cash_credit_od_limits");

            migrationBuilder.DropTable(
                name: "application_contacts");

            migrationBuilder.DropTable(
                name: "application_existing_loans");

            migrationBuilder.DropTable(
                name: "application_purpose_of_loan");

            migrationBuilder.DropTable(
                name: "application_reference");

            migrationBuilder.DropTable(
                name: "applications");

            migrationBuilder.DropTable(
                name: "business_address");

            migrationBuilder.DropTable(
                name: "business_contact_numbers");

            migrationBuilder.DropTable(
                name: "business_details");

            migrationBuilder.DropTable(
                name: "business_nature");

            migrationBuilder.DropTable(
                name: "contact_address");

            migrationBuilder.DropTable(
                name: "contact_mode_of_communication");

            migrationBuilder.DropTable(
                name: "contact_number_type");

            migrationBuilder.DropTable(
                name: "contact_numbers");

            migrationBuilder.DropTable(
                name: "contact_relation_with_borrower");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "customer_bank_info");

            migrationBuilder.DropTable(
                name: "gst_detail_info");

            migrationBuilder.DropTable(
                name: "gst_master_info");

            migrationBuilder.DropTable(
                name: "lead_source");

            migrationBuilder.DropTable(
                name: "merchant_bank_info");

            migrationBuilder.DropTable(
                name: "merchant_processors");

            migrationBuilder.DropTable(
                name: "mst_account_type");

            migrationBuilder.DropTable(
                name: "mst_address");

            migrationBuilder.DropTable(
                name: "mst_address_proof");

            migrationBuilder.DropTable(
                name: "mst_address_type");

            migrationBuilder.DropTable(
                name: "mst_agents");

            migrationBuilder.DropTable(
                name: "mst_branch");

            migrationBuilder.DropTable(
                name: "mst_business_entity_type");

            migrationBuilder.DropTable(
                name: "mst_business_registered");

            migrationBuilder.DropTable(
                name: "mst_business_unit");

            migrationBuilder.DropTable(
                name: "mst_city");

            migrationBuilder.DropTable(
                name: "mst_control_program");

            migrationBuilder.DropTable(
                name: "mst_country");

            migrationBuilder.DropTable(
                name: "mst_cust_type");

            migrationBuilder.DropTable(
                name: "mst_docs_file");

            migrationBuilder.DropTable(
                name: "mst_dsa");

            migrationBuilder.DropTable(
                name: "mst_edc_terminal");

            migrationBuilder.DropTable(
                name: "mst_education_type");

            migrationBuilder.DropTable(
                name: "mst_external_agents");

            migrationBuilder.DropTable(
                name: "mst_industry");

            migrationBuilder.DropTable(
                name: "mst_internal_agents");

            migrationBuilder.DropTable(
                name: "mst_mar_status");

            migrationBuilder.DropTable(
                name: "mst_occupation_type");

            migrationBuilder.DropTable(
                name: "mst_omc");

            migrationBuilder.DropTable(
                name: "mst_premises_type");

            migrationBuilder.DropTable(
                name: "mst_region");

            migrationBuilder.DropTable(
                name: "mst_scheme");

            migrationBuilder.DropTable(
                name: "mst_source");

            migrationBuilder.DropTable(
                name: "mst_state");

            migrationBuilder.DropTable(
                name: "mst_sub_industry");

            migrationBuilder.DropTable(
                name: "mst_titles");

            migrationBuilder.DropTable(
                name: "mst_user");

            migrationBuilder.DropTable(
                name: "ng_directors_matrix");

            migrationBuilder.DropTable(
                name: "repay_mechanism_master");

            migrationBuilder.DropTable(
                name: "utility_master");
        }
    }
}
