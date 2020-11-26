using apiPatternCQRS.WebApi.Application.Models.ResponseModels.QueryResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Models.RequestModels.QueryRequestModels
{
    public class GetVillainByIdRequestModel : IRequest<GetVillainByIdResponseModel>
    {
        public int VillainId { get; set; }

        public GetVillainByIdRequestModel(int villainId)
        {
            VillainId = villainId;
        }
    }
}
