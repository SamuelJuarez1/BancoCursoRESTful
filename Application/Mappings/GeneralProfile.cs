using Application.Feautres.Clientes.Commands.CreateClienteCommand;
using Application.Feautres.Clientes.Commands.UpdateClienteCommand;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile() 
        {
            #region Commands
            CreateMap<CreateClienteCommand, Cliente>();
            CreateMap<UpdateClienteCommand, Cliente>();
            #endregion
        }
    }
}
