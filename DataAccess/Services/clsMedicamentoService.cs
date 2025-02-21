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
    public class clsMedicamentoService : IMedicamentoService
    {
        private readonly IMedicamentoRepository _medicamentoRepository;
        public clsMedicamentoService (IMedicamentoRepository medicamentoRepository)
        {
            _medicamentoRepository = medicamentoRepository;
        }

        public async Task<clsOperationResult> ObtenerTodosAsync()
        {
            return await _medicamentoRepository.GetAllAsync();
        }
        public async Task<clsOperationResult> ObtenerPorIdAsync(int id)
        {
            return await _medicamentoRepository.GetByIdAsync(id);
        }
        public async Task<clsOperationResult> AgregarAsync(clsMedicamento entity)
        {
            var vMedicamento = new clsMedicamento
            {
                Nombre = clsStringFormatter.ToTitleCase(entity.Nombre),
                Precio = entity.Precio,
                Activo = entity.Activo
            };

            return await _medicamentoRepository.AddAsync(vMedicamento);
        }


        public Task<clsOperationResult> ActualizarAsync(clsMedicamento entity)
        {
            var vMedicamento = new clsMedicamento
            {
                Nombre = clsStringFormatter.ToTitleCase(entity.Nombre),
                Precio = entity.Precio,
                Activo = entity.Activo
            };
            return _medicamentoRepository.UpdateAsync(vMedicamento);
        }
        public async Task<clsOperationResult> EliminarAsync(int id)
        {
            return await _medicamentoRepository.DeleteAsync(id);
        }
        public async Task<clsOperationResult> CambiarEstado(int id)
        {
            var vMedicamento = await _medicamentoRepository.GetByIdAsync(id);

            if (vMedicamento.Data is clsMedicamento vMedicamentoData)
            {
                bool vNuevoEstado = !vMedicamentoData.Activo;
                return await _medicamentoRepository.CambiarEstado(id, vNuevoEstado);
            }

            return vMedicamento;
        }
    }
}
