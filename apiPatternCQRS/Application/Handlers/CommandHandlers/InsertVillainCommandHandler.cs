using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.CommandResponseModel;
using apiPatternCQRS.WebApi.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Handlers.CommandHandlers
{
    public class InsertVillainCommandHandler : IRequestHandler<InsertVillainRequestModel, InsertVillainResponseModel>
    {
        private readonly IVillainRepository _villainRepository;
        public InsertVillainCommandHandler(IVillainRepository villainRepository)
        {
            _villainRepository = villainRepository;
        }

        public async Task<InsertVillainResponseModel> Handle(InsertVillainRequestModel request, CancellationToken cancellationToken)
        {
            var response = await _villainRepository.Insert(request);
            return response;
        }      
    }
}
