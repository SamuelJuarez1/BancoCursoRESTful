﻿using Application.Feautres.Clientes.Commands.CreateClienteCommand;
using Application.Feautres.Clientes.Commands.DeleteClienteCommand;
using Application.Feautres.Clientes.Commands.UpdateClienteCommand;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebAPI.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ClientesController : BaseApiController
    {
        //POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateClienteCommand command)
        {
            return Ok (await Mediator.Send (command));  
        }

        //PUT api/<controller>
        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateClienteCommand command)
        {
            if (id != command.Id)
                return BadRequest();
            return Ok(await Mediator.Send(command));
        }

        //DELETE api/<controller>
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteClienteCommand { Id = id }));
        }

    }
}


