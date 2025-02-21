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
    public class clsMedicamentoFrecuenciaService : IMedicamentoFrecuenciaService
    {
        private readonly Interfaces.Repository.IMedicamentoFrecuenciaRepository _medicamentoFrecuenciaRepository;
        public clsMedicamentoFrecuenciaService(Interfaces.Repository.IMedicamentoFrecuenciaRepository medicamentoFrecuenciaRepository)
        {
            _medicamentoFrecuenciaRepository = medicamentoFrecuenciaRepository;
        }

        public async Task<clsOperationResult> ObtenerPorIdAsync(int id)
        {
            return await _medicamentoFrecuenciaRepository.GetByIdAsync(id);
        }

        public async Task<clsOperationResult> ObtenerTodosAsync()
        {
            return await _medicamentoFrecuenciaRepository.GetAllAsync();
        }
        public async Task<clsOperationResult> AgregarAsync(clsMedicamentoFrecuencia entity)
        {
            var vMedFrecuencia = new clsMedicamentoFrecuencia
            {
                Id = entity.Id,
                ClienteId = entity.ClienteId,
                MedicamentoId = entity.MedicamentoId,
                FrecuenciaDiaria = entity.FrecuenciaDiaria

            };

            return await _medicamentoFrecuenciaRepository.AddAsync(vMedFrecuencia);
        }

        public async Task<clsOperationResult> ActualizarAsync(clsMedicamentoFrecuencia entity)
        {
            var vMedFrecuencia = new clsMedicamentoFrecuencia
            {
                Id = entity.Id,
                ClienteId = entity.ClienteId,
                MedicamentoId = entity.MedicamentoId,
                FrecuenciaDiaria = entity.FrecuenciaDiaria
            };

            return await _medicamentoFrecuenciaRepository.UpdateAsync(vMedFrecuencia);
        }

        public Task<clsOperationResult> EliminarAsync(int id)
        {
            return _medicamentoFrecuenciaRepository.DeleteAsync(id);
        }
    }
}
