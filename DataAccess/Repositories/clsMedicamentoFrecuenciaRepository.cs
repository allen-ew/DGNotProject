using DgNotification.DataAccess.Interfaces.Repository;
using DgNotification.DataAccess.Models;
using DgNotification.Shared.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Repositories
{
    public class clsMedicamentoFrecuenciaRepository: IMedicamentoFrecuenciaRepository
    {
        private readonly clsDGNotiDBContext _context;

        public clsMedicamentoFrecuenciaRepository(clsDGNotiDBContext context)
        {
            _context = context;
        }
        public async Task<clsOperationResult> GetAllAsync()
        {
            try
            {
                var vMedicamento = await _context.MedicamentoFrecuencias.ToListAsync();
                return vMedicamento.Any()
                    ? clsOperationResult.SuccessResult("Medicamentos (frecuencia) obtenidos correctamente.", vMedicamento)
                    : clsOperationResult.FailureResult("No se encontraron medicamentos (frecuencia).");
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al obtener los medicamentos (frecuencia) : " + ex.Message);
            }
        }

        public async Task<clsOperationResult> GetByIdAsync(int id)
        {
            try
            {
                var vMedicamento = await _context.MedicamentoFrecuencias.FindAsync(id);
                return vMedicamento != null
                    ? clsOperationResult.SuccessResult("Medicamento (frecuencia) por id obtenido correctamente.", vMedicamento)
                    : clsOperationResult.FailureResult("No se encontro el medicamento (frecuencia) con el id especificado.");
            }
            catch (Exception ex )
            {

                return clsOperationResult.FailureResult("Error al obtener la frecuencia del medicamento: " + ex.Message); 
            }
        }

        public async Task<clsOperationResult> AddAsync(clsMedicamentoFrecuencia entity)
        {
            try
            {
                if(entity == null) return clsOperationResult.FailureResult("La frecuencia del medicamento no puede ser nula.");
                await _context.MedicamentoFrecuencias.AddAsync(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Frecuencia del medicamento agregada correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar la frecuencia del medicamento: " + ex.Message);
            }
        }
        public async Task<clsOperationResult> UpdateAsync(clsMedicamentoFrecuencia entity)
        {
            try
            {
                if (entity == null) return clsOperationResult.FailureResult("La frecuencia del medicamento no puede ser nula.");
                _context.MedicamentoFrecuencias.Update(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Frecuencia del medicamento actualizada correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al actualizar la frecuencia del medicamento: " + ex.Message);
            }
            ;
        }

        public async Task<clsOperationResult> DeleteAsync(int id)
        {
            try
            {
                var vMedicamento = await _context.MedicamentoFrecuencias.FindAsync(id);
                if (vMedicamento == null) return clsOperationResult.FailureResult("La frecuencia del medicamento no puede ser nula.");
                _context.MedicamentoFrecuencias.Update(vMedicamento);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Frecuencia del medicamento actualizada correctamente.", vMedicamento);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al eliminar la frecuencia del medicamento: " + ex.Message);
            }
        }
 
    }
}
