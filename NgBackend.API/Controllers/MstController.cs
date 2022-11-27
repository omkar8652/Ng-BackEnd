using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NgBackend.Application.CQRS.AccountType;
using NgBackend.Application.CQRS.BankInfo;
using NgBackend.Application.CQRS.Branch;
using NgBackend.Application.CQRS.business_entity_type;
using NgBackend.Application.CQRS.BusinessRegistered;
using NgBackend.Application.CQRS.BusinessUnit;
using NgBackend.Application.CQRS.City;
using NgBackend.Application.CQRS.ControlProgram;
using NgBackend.Application.CQRS.Country;
using NgBackend.Application.CQRS.DsaCode;
using NgBackend.Application.CQRS.EducationType;
using NgBackend.Application.CQRS.ExternalAgents;
using NgBackend.Application.CQRS.Industry;
using NgBackend.Application.CQRS.InternalAgents;
using NgBackend.Application.CQRS.MaritalStatus;
using NgBackend.Application.CQRS.MasterAddressProof;
using NgBackend.Application.CQRS.MasterTitles;
using NgBackend.Application.CQRS.ModeOfCommunication;
using NgBackend.Application.CQRS.Mst_UtilityMaster;
using NgBackend.Application.CQRS.MstBusinessAddress;
using NgBackend.Application.CQRS.MstBusinessNature;
using NgBackend.Application.CQRS.NumberType;
using NgBackend.Application.CQRS.OccupationType;
using NgBackend.Application.CQRS.Omc;
using NgBackend.Application.CQRS.PremisesType;
using NgBackend.Application.CQRS.PurposeOfLoan;
using NgBackend.Application.CQRS.Regions;
using NgBackend.Application.CQRS.RelationWithBorrowerContact;
using NgBackend.Application.CQRS.SalesUserMstAgents;
using NgBackend.Application.CQRS.Scheme;
using NgBackend.Application.CQRS.Source;
using NgBackend.Application.CQRS.State;
using NgBackend.Application.CQRS.User;

namespace NgBackend.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MstController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MstController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("MstTitle")]
        public async Task<IActionResult> MstTitle()
        {
            var command = new MstTitlesQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstBusinessUnit")]
        public async Task<IActionResult> MstBusinessUnit()
        {
            var command = new MstBusinessUnitQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstSource")]
        public async Task<IActionResult> MstSource()
        {
            var command = new MstSourceQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstInternalAgents")]
        public async Task<IActionResult> MstInternalAgents()
        {
            var command = new MstInternalAgentsQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("MstExternalAgents")]
        public async Task<IActionResult> MstExternalAgentsQuery()
        {
            var command = new MstExternalAgentsQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("MstDsa")]
        public async Task<IActionResult> MstDsaQuery()
        {
            var command = new MstDsaQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstAgents")]
        public async Task<IActionResult> IMstAgents()
        {
            var command = new MstAgentsQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstBranch")]
        public async Task<IActionResult> MstBranch()
        {
            var command = new MstBranchQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstRegions")]
        public async Task<IActionResult> MstRegions()
        {
            var command = new MstRegionsQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstScheme")]
        public async Task<IActionResult> MstScheme()
        {
            // Error :  Microsoft.Data.SqlClient.SqlException (0x80131904): Invalid column name 'Id'.
            //   Invalid column name 'ApplicationsId'.
            var command = new MstSchemeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        // IApplicationPurposeOfLoan

        [HttpGet("ApplicationPurposeOfLoan")]
        public async Task<IActionResult> ApplicationPurposeOfLoan()
        {
            var command = new ApplicationPurposeOfLoanQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("MstUser")]
        public async Task<IActionResult> MstUser()
        {
            var command = new MstUserQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }


        [HttpGet("UtilityMaster")]
        public async Task<IActionResult> UtilityMasterQuery()
        {
            var command = new UtilityMasterQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("mst_business_entity_typeQuery")]
        public async Task<IActionResult> mst_business_entity_typeQuery()
        {
            var command = new mst_business_entity_typeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("BusinessNature")]
        public async Task<IActionResult> BusinessNature()
        {
            var command = new BusinessNatureQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("MstControlProgram")]
        public async Task<IActionResult> MstControlProgram()
        {
            var command = new MstControlProgramQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstIndustry")]
        public async Task<IActionResult> MstIndustryQuery()
        {
            var command = new MstIndustryQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstOmc")]
        public async Task<IActionResult> MstOmcQuery()
        {
            var command = new MstOmcQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpGet("MstPremisesType")]
        public async Task<IActionResult> MstPremisesType()
        {
            var command = new MstPremisesTypeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

         [HttpGet("MstCountry")]
        public async Task<IActionResult> MstCountry()
        {
            var command = new MstCountryQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

         [HttpGet("MstState")]
        public async Task<IActionResult> MstState()
        {
            var command = new MstStateQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        
         [HttpGet("MstCity")]
        public async Task<IActionResult> MstCity()
        {
            var command = new MstCityQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

         [HttpGet("ContactNumberType")]
        public async Task<IActionResult> ContactNumber()
        {
            var command = new ContactNumberTypeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        
         [HttpGet("BusinessAddress")]
        public async Task<IActionResult> BusinessAddress()
        {
            var command = new BusinessAddressQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("ContactRelationWithBorrower")]
        public async Task<IActionResult> ContactRelationWithBorrower()
        {
            var command = new ContactRelationWithBorrowerQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }
     
        [HttpGet("ContactModeOfCommunication")]
        public async Task<IActionResult> ContactModeOfCommunication()
        {
            var command = new ContactModeOfCommunicationQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

         [HttpGet("MstMarStatus")]
        public async Task<IActionResult> MstMarStatus()
        {
            var command = new MstMarStatusQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        
         [HttpGet("MstOccupationType")]
        public async Task<IActionResult> MstOccupationType()
        {
            var command = new MstOccupationTypeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("MstEducationType")]
        public async Task<IActionResult> MstEducationType()
        {
            var command = new MstEducationTypeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

         [HttpGet("CustomerBank")]
        public async Task<IActionResult> CustomerBank()
        {
            var command = new CustomerBankInfoQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

         [HttpGet("AddressProof")]
        public async Task<IActionResult> MstAddressProof()
        {
            var command = new MstAddressProofQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

          [HttpGet("MstAccountType")]
        public async Task<IActionResult> MstAccountType()
        {
            var command = new MstAccountTypeQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        
          [HttpGet("MstBusinessRegistered")]
        public async Task<IActionResult> MstBusinessRegistered()
        {
            var command = new MstBusinessRegisteredQuery();
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
