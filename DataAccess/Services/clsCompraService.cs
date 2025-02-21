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
    public class clsCompraService : ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        public clsCompraService(ICompraRepository compraRepository)
        {
            _compraRepository = compraRepository;
        }

        public async Task<clsOperationResult> ObtenerPorIdAsync(int id)
        {
            return await _compraRepository.GetByIdAsync(id);
        }

        public async Task<clsOperationResult> ObtenerTodosAsync()
        {
            return await _compraRepository.GetAllAsync();
        }
        public async Task<clsOperationResult> AgregarAsync(clsCompra entity)
        {
            var vCompra = new clsCompra
            {
                ClienteId = entity.ClienteId,
                MedicamentoId = entity.MedicamentoId,
                FechaCompra = entity.FechaCompra,
                FrecuenciaCompra = entity.FrecuenciaCompra,
                CantidadComprada = entity.CantidadComprada,
                PrecioUnitario = entity.PrecioUnitario

            };

            return await _compraRepository.AddAsync(vCompra);
        }

        public async Task<clsOperationResult> ActualizarAsync(clsCompra entity)
        {
            var vCompra = new clsCompra
            {
                ClienteId = entity.ClienteId,
                MedicamentoId = entity.MedicamentoId,
                FechaCompra = entity.FechaCompra,
                FrecuenciaCompra = entity.FrecuenciaCompra,
                CantidadComprada = entity.CantidadComprada,
                PrecioUnitario = entity.PrecioUnitario
            };

            return await _compraRepository.UpdateAsync(vCompra);
        }

        public Task<clsOperationResult> EliminarAsync(int id)
        {
            return _compraRepository.DeleteAsync(id);
        }
        

        
    }
}
