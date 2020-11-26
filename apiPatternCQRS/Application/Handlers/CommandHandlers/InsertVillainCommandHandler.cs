using apiPatternCQRS.WebApi.Application.Models.RequestModels.CommandRequestModels;
using apiPatternCQRS.WebApi.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace apiPatternCQRS.WebApi.Application.Handlers.CommandHandlers
{
    public class InsertVillainCommandHandler : IRequestHandler<InsertVillainRequestModel, string>
    {
        private readonly IVillainRepository _villainRepository;
        public InsertVillainCommandHandler(IVillainRepository villainRepository)
        {
            _villainRepository = villainRepository;
        }

        public Task<string> Handle(InsertVillainRequestModel request, CancellationToken cancellationToken)
        {
            _villainRepository.Insert(request);
            return Task.FromResult("O Vilão foi inserido com sucesso");
        }      
    }
}
