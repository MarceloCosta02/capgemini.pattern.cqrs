using apiPatternCQRS.WebApi.Application.Models.RequestModels.QueryRequestModels;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.QueryResponseModel;
using apiPatternCQRS.WebApi.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Handlers.QueryHandlers
{
    public class GetVillainByIdQueryHandler : IRequestHandler<GetVillainByIdRequestModel, GetVillainByIdResponseModel>
    {
        private readonly IVillainRepository _villainRepository;

        public GetVillainByIdQueryHandler(IVillainRepository villainRepository)
        {
            _villainRepository = villainRepository;
        }

        public async Task<GetVillainByIdResponseModel> Handle(GetVillainByIdRequestModel request, CancellationToken cancellationToken)
        {
            var response = await _villainRepository.GetById(request);
            return response;
        }       
    }
}
