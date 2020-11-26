using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Models.ResponseModels.QueryResponseModel
{
    public class GetVillainByIdResponseModel
    {
        public int VillainId { get; set; }
        public string SuperVillainName { get; set; }
        public string SuperPower { get; set; }
        public string Weapon { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
