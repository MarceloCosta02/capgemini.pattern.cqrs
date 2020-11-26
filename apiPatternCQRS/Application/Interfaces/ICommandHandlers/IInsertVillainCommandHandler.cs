using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Interfaces.ICommandHandlers
{
    public interface IInsertVillainCommandHandler
    {
        string InsertVillian(InsertVillainRequestModel requestModel);
    }
}
