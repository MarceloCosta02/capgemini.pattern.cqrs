using apiPatternCQRS.WebApi.Application.Models.ResponseModels.CommandResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels
{
    public class InsertVillainRequestModel : IRequest<InsertVillainResponseModel>
    {
        public int VillainId { get; set; }
        public string SuperVillainName { get; set; }
        public string SuperPower { get; set; }
        public string Weapon { get; set; }
        public DateTime BirthDate { get; set; }        
    }
}
