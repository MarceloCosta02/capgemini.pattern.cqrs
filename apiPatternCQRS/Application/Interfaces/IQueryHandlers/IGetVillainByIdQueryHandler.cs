using apiPatternCQRS.WebApi.Application.Models.RequestModels.QueryRequestModels;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.QueryResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Interfaces.IQueryHandlers
{
    public interface IGetVillainByIdQueryHandler
    {
        Task<GetVillainByIdResponseModel> GetVillainById(GetVillainByIdRequestModel requestModel);
    }
}
