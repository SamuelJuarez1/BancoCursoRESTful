using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Feautres.Clientes.Commands.UpdateClienteCommand
{
    public class UpdateClienteCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
    }
    public class UpdateClienteCommandHandler : IRequestHandler<UpdateClienteCommand, Response<int>>
    {
        private readonly IRepositoryAsync<Cliente> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateClienteCommandHandler(IRepositoryAsync<Cliente> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync = repositoryAsync;
            _mapper = mapper;
        } 
       
        public async Task<Response<int>> Handle(UpdateClienteCommand request, CancellationToken cancellationToken)
        {
            var clientes = await _repositoryAsync.GetByIdAsync(request.Id);

            if (clientes == null)
            {
                throw new KeyNotFoundException($"Registro no encontrado con el Id {request.Id}");
            }

            else
            {
                clientes.Nombre = request.Nombre;
                clientes.Apellido = request.Apellido;
                clientes.FechaNacimiento = request.FechaNacimiento;
                clientes.Telefono= request.Telefono; 
                clientes.Email = request.Email;  
                clientes.Direccion= request.Direccion;

                await _repositoryAsync.UpdateAsync(clientes);

                return new Response<int>(clientes.Id);

            }
        }

       
    }
}
