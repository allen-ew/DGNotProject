using DgNotification.DataAccess.Interfaces.Repository;
using DgNotification.DataAccess.Interfaces.Services;
using DgNotification.DataAccess.Models;
using DgNotification.DataAccess.Repositories;
using DgNotification.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Services
{

    public class clsClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public clsClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<clsOperationResult> ObtenerTodosAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }
        public async Task<clsOperationResult> ObtenerPorIdAsync(int id)
        {
            return await _clienteRepository.GetByIdAsync(id);
        }
        public async Task<clsOperationResult> AgregarAsync(clsCliente entity)
        {
            var vCliente = new clsCliente{
                Nombre = clsStringFormatter.ToTitleCase(entity.Nombre),
                Apellido = clsStringFormatter.ToTitleCase(entity.Apellido),
                Direccion = entity.Direccion,
                Cedula = entity.Cedula,
                Activo = entity.Activo
            };
            
            return await _clienteRepository.AddAsync(vCliente);
        }


        public Task<clsOperationResult> ActualizarAsync(clsCliente entity)
        {
            var vCliente = new clsCliente
            {
                Id = entity.Id,
                Nombre = entity.Nombre,
                Apellido = entity.Apellido,
                Direccion = entity.Direccion,
                Cedula = entity.Cedula,
                Activo = entity.Activo
            };
            return _clienteRepository.UpdateAsync(vCliente);
        }
        public async Task<clsOperationResult> EliminarAsync(int id)
        {
            return await _clienteRepository.DeleteAsync(id);
        }
        public async Task<clsOperationResult> CambiarEstado(int id)
        {
            var vCliente = await _clienteRepository.GetByIdAsync(id);

            if (vCliente.Data is clsCliente vClienteData)
            {
                bool vNuevoEstado = !vClienteData.Activo;
                return await _clienteRepository.CambiarEstado(id, vNuevoEstado);
            }

            return vCliente;
        }


    }
}
