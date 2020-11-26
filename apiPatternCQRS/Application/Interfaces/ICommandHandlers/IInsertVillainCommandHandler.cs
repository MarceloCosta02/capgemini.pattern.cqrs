using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.CommandResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Interfaces.ICommandHandlers
{
    public interface IInsertVillainCommandHandler
    {
        InsertVillainResponseModel GetVillainById(InsertVillainRequestModel requestModel);
    }
}
