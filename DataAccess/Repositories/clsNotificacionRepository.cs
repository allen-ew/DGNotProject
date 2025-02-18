using DgNotification.DataAccess.Interfaces;
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
    public class clsNotificacionRepository : IGeneric<clsNotificacion>
    {
        private readonly clsDGNotiDBContext _context;
        public clsNotificacionRepository(clsDGNotiDBContext prmContext)
        {
            _context = prmContext;
        }

        public async Task<clsOperationResult> GetAllAsync()
        {
            try
            {
                var vNotificaciones = await _context.Notificaciones.ToListAsync();
                return vNotificaciones.Any()
                    ? clsOperationResult.SuccessResult("Notificaciones obtenidas correctamente.", vNotificaciones)
                    : clsOperationResult.FailureResult("No se encontraron notificaciones.");
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al obtener notificaciones: " + ex.Message);
            }
        }

        public async Task<clsOperationResult> GetByIdAsync(int id)
        {
            try
            {
                var vNotificacion = await _context.Notificaciones.FindAsync(id);

                return vNotificacion != null
                    ? clsOperationResult.SuccessResult("Notificacion obtenida correctamente.", vNotificacion)
                    : clsOperationResult.FailureResult("No se encontro la notificacion.");
            }
            catch (Exception ex) 
            {

                return clsOperationResult.FailureResult("Error al obtener notificacion: " + ex.Message); ;
            }
            
        }
        public async Task<clsOperationResult> AddAsync(clsNotificacion entity)
        {
            try
            {
                if(entity == null) return clsOperationResult.FailureResult("La notificacion no puede ser nula.");
                await _context.Notificaciones.AddAsync(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Notificacion agregada correctamente.",entity);
            }
            catch (Exception ex )
            {

                return clsOperationResult.FailureResult("Error al agregar notificacion :" + ex.Message);
            }
        }

        public async Task<clsOperationResult> UpdateAsync(clsNotificacion entity)
        {
            try
            {
               if (entity == null) return clsOperationResult.FailureResult("La notificacion no puede ser nula.");
                _context.Notificaciones.Update(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Notificacion actualizada correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar notificacion :" + ex.Message);
            }
        }
        public async Task<clsOperationResult> DeleteAsync(int id)
        {
            try
            {
                var vNotificacion = await _context.Notificaciones.FindAsync(id);
                if (vNotificacion == null) return clsOperationResult.FailureResult("La notificacion no existe.");
                _context.Notificaciones.Remove(vNotificacion);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Notificacion eliminada correctamente.");
            }
            catch (Exception ex)
            {
                return clsOperationResult.FailureResult("Error al eliminar notificacion: " + ex.Message);
            }
        }
    }
}
