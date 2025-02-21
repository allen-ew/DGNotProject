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
    public class clsMedicamentoRepository : IMedicamentoRepository
    {
        private readonly clsDGNotiDBContext _context;

        public clsMedicamentoRepository(clsDGNotiDBContext prmContext)
        {
            _context = prmContext;
        }

        public async Task<clsOperationResult> GetAllAsync()
        {
             var vMedicamentos = await _context.Medicamentos.ToListAsync();
            return vMedicamentos.Any()
                ? clsOperationResult.SuccessResult("Medicamentos obtenidos correctamente.", vMedicamentos)
                : clsOperationResult.FailureResult("No se encontraron medicamentos.");
        }
        public async Task<clsOperationResult> GetByIdAsync(int id)
        {
            var vMedicamento = await _context.Medicamentos.FindAsync(id);
            return vMedicamento != null
                ? clsOperationResult.SuccessResult("Medicamento por id obtenido correctamente.", vMedicamento)
                : clsOperationResult.FailureResult("No se encontro el medicamento con el id especificado.");
        }
        public async Task<clsOperationResult> AddAsync(clsMedicamento entity)
        {
            try
            {
                if (entity == null) return clsOperationResult.FailureResult("El medicamento no puede ser nulo.");
                await _context.Medicamentos.AddAsync(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Medicamento agregado correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar un Medicamento: " + ex.Message);
            }
        }
        public async Task<clsOperationResult> UpdateAsync(clsMedicamento entity)
        {
            try
            {
                if(entity == null) return clsOperationResult.FailureResult("El medicamento no puede ser nulo.");
                _context.Medicamentos.Update(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Medicamento actualizado correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar un Medicamento: " + ex.Message);
            }
        }
        public async Task<clsOperationResult> DeleteAsync(int id)
        {
            try
            {
                var vMedicamento = await _context.Medicamentos.FindAsync(id);
                if (vMedicamento == null) return clsOperationResult.FailureResult("El medicamento no puede ser nulo.");
                _context.Medicamentos.Update(vMedicamento);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Medicamento actualizado correctamente.", vMedicamento);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar un Medicamento: " + ex.Message);
            }
        }
        public async Task<clsOperationResult> CambiarEstado(int id, bool estado)
        {
            try
            {
                var vMedicamento = await _context.Medicamentos.FindAsync(id);
                if (vMedicamento == null) return clsOperationResult.FailureResult("El medicamento no existe.");
                vMedicamento.Activo = estado;
                _context.Medicamentos.Update(vMedicamento);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("El estado del medicamento fue cambiado correctamente.", vMedicamento);
            }
            catch (Exception ex)
            {
                return clsOperationResult.FailureResult("Error al cambiar el estado del medicamento: " + ex.Message);
            }
        }
    }
    
}
