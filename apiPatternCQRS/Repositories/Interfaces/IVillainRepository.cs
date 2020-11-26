using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using apiPatternCQRS.WebApi.Application.Models.RequestModels.QueryRequestModels;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.CommandResponseModel;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.QueryResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Repositories.Interfaces
{
    public interface IVillainRepository
    {
        /// <summary>
        /// Metodo para inclusao de Vilões no banco de dados
        /// </summary>
        /// <param name="villain"></param>
        /// <returns></returns>
        InsertVillainResponseModel Insert(InsertVillainRequestModel villain);

        /// <summary>
        /// Recupera um vilão pelo id
        /// </summary>
        /// <param name="villain"></param>
        /// <returns></returns>
        IEnumerable<GetVillainByIdResponseModel> GetById(GetVillainByIdRequestModel villain);
    }
}
