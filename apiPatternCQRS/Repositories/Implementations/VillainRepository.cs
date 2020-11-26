﻿using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using apiPatternCQRS.WebApi.Application.Models.RequestModels.QueryRequestModels;
using apiPatternCQRS.WebApi.Application.Models.ResponseModels.QueryResponseModel;
using apiPatternCQRS.WebApi.Repositories.Interfaces;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Repositories.Implementations
{
    public class VillainRepository : IVillainRepository
    {
        private readonly string _connectionString;
        public VillainRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Metodo para inclusao de Vilões no banco de dados
        /// </summary>
        /// <param name="villain"></param>
        /// <returns></returns>
        public void Insert(InsertVillainRequestModel villain)
        {
            var connection = new SqlConnection(_connectionString);

            var query = "insert into villain (villain_id, super_villain_name, super_power, weapon, birth_date) " +
                            "values (@villain_id, @super_villain_name, @super_power, @weapon, @birth_date)";

            var result = connection.Execute(query, new 
            { 
                villain_id = villain.VillainId,
                super_villain_name = villain.SuperVillainName,
                super_power = villain.SuperPower,
                weapon = villain.Weapon,
                birth_date = villain.BirthDate
            });         
        }

        /// <summary>
        /// Recupera um vilão pelo id
        /// </summary>
        /// <param name="villain"></param>
        /// <returns></returns>
        public async Task<GetVillainByIdResponseModel> GetById(GetVillainByIdRequestModel villain)
        {
            var connection = new SqlConnection(_connectionString);

            var query = "select villainid, supervillainname, superpower, weapon, birthdate from villain " +
                            "where villainid = @villainid";
            
            var result = await connection.QueryAsync<GetVillainByIdResponseModel>(query, new { villainid = villain.VillainId });

            return result.FirstOrDefault();
        }
    }
}
