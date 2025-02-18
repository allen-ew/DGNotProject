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
    public class clsCompraRepository : IGeneric<clsCompra>
    {
        
        private readonly clsDGNotiDBContext _context;

        public clsCompraRepository(clsDGNotiDBContext prmContext)
        {
            _context = prmContext;
        }
        public async Task<clsOperationResult> GetAllAsync()
        {
            try
            {
                var vCompras = await _context.Compras.ToListAsync();
                return vCompras.Any()
                    ? clsOperationResult.SuccessResult("Compras obtenidas correctamente.", vCompras)
                    : clsOperationResult.FailureResult("No se encontraron compras.");
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al obtener compras:" + ex.Message);
            }
        }

        public async Task<clsOperationResult> GetByIdAsync(int id)
        {
            try
            {
                var vCompra = await _context.Compras.FindAsync(id);
                return vCompra != null
                    ? clsOperationResult.SuccessResult("Compra por id obtenida correctamente.", vCompra)
                    : clsOperationResult.FailureResult("No se encontro la compra con el id especificado.");
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al obtener la compra: " + ex.Message);
            }
        }

        public async Task<clsOperationResult> AddAsync(clsCompra entity)
        {
            try
            {
                if (entity == null) return clsOperationResult.FailureResult("El cliente no puede ser nulo.");
                await _context.Compras.AddAsync(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Compra agregada correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar un cliente: " + ex.Message);
            }
        }
        public async Task<clsOperationResult> UpdateAsync(clsCompra entity)
        {
            try
            {
                if (entity == null) return clsOperationResult.FailureResult("La compra no puede ser nula.");
                _context.Compras.Update(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Compra actualizada correctamente.", entity);
            }
            catch (Exception ex)
            {
                return clsOperationResult.FailureResult("Error al actualizar la compra: " + ex.Message);
            }
        }

        public async Task<clsOperationResult> DeleteAsync(int id)
        {
            try
            {
                var vCompra = await _context.Compras.FindAsync(id);
                if (vCompra == null) return clsOperationResult.FailureResult("La compra no existe.");
                _context.Compras.Remove(vCompra);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Compra eliminada correctamente.", vCompra);

            }
            catch (Exception ex )
            {

                return clsOperationResult.FailureResult("Error al eliminar la compra: " + ex.Message);
            }
        }


        
    }
}
