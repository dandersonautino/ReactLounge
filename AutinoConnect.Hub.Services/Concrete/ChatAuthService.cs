using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutinoConnect.Data.CarVue.Models.Models;
using AutinoConnect.DataAccess.Interfaces;
using AutinoConnect.Hub.Services.Exceptions;
using AutinoConnect.Hub.Services.Interface;
using AutinoConnect.Shared.Model.Chat;
using AutinoConnect.Utility.Interfaces;
using Microsoft.Extensions.Logging;
namespace AutinoConnect.Hub.Services.Concrete
{
    public class ChatAuthService : IChatAuthService
    {
        public async Task<ChatAuthenticationModel> GetAuthModelAndValidateData(string authKey, int enquiryPartner)
        {
            var authDataModel = GetAuthModel(authKey);

            GarageEnquiryPartner partner;
            try
            {
                partner= await _unitOfWork.RepositoryIntKey<GarageEnquiryPartner>().FindBy(a =>
                    a.GarageRef == authDataModel.GarageRef.Value && a.EnquiryPartnerId == enquiryPartner);

            }
            catch (GarageNotFoundForPartnerException e)
            {
                _logger.LogError(e.Message, e);
                throw;
            }

            var enquiry = await _unitOfWork.RepositoryIntKey<Enquiry>().FindBy(a =>
                a.GarageId== partner.GarageId && a.EnquiryRef== authDataModel.JobRef.Value);
            if (enquiry == null)
            {
                throw new JobNotFoundException($"Job ref {authDataModel.JobRef.Value} was not found on an enquiry");
            }

            return authDataModel;
        }

        public ChatAuthenticationModel GetAuthModel(string authKey)
        {
            ChatAuthenticationModel authDataModel;
            try
            {
                authDataModel = _modelToQueryStringService.Deserialize<ChatAuthenticationModel>(authKey);
            }
            catch (Exception e)
            {
                var error = new ArgumentException("Unable to deserialize model : " + e.Message, e);
                _logger.LogError(e.Message, e);
                throw error;
            }

            if (!authDataModel.JobRef.HasValue)
            {
                var e = new ArgumentException("Job ref was null");
                _logger.LogError(e.Message, e);
                throw e;
            }

            if (!authDataModel.GarageRef.HasValue)
            {
                var e = new ArgumentException("GarageRef ref was null");
                _logger.LogError( e.Message, e);
                throw e;
            }

            return authDataModel;
        }

       
        public ChatAuthService(ILogger< ChatAuthService> logger, IModelToQueryStringService modelToQueryStringService, IUnitOfWork<ACCarVueContext> unitOfWork)
        {
            _logger = logger;
            _modelToQueryStringService = modelToQueryStringService;
            _unitOfWork = unitOfWork;
          
        }
        private ILogger<ChatAuthService> _logger;
        private IModelToQueryStringService _modelToQueryStringService;

        private IUnitOfWork<ACCarVueContext> _unitOfWork;
       
    }
}
