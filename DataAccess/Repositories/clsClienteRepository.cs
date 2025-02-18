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
    public class clsClienteRepository : IGeneric<clsCliente>
    {
        private readonly clsDGNotiDBContext _context;

        public clsClienteRepository(clsDGNotiDBContext prmContext)
        {
            _context = prmContext;
        }
        //Posible mejora (Repositorio generico)
        public async Task<clsOperationResult> GetAllAsync()
        {
            try
            {
                var vClientes = await _context.Clientes.ToListAsync();
                return vClientes.Any()
                    ? clsOperationResult.SuccessResult("Clientes obtenidos correctamente.", vClientes)
                    : clsOperationResult.FailureResult("No se encontraron clientes.");

            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al obtener clientes:" + ex.Message);
            }
        }

        public async Task<clsOperationResult> GetByIdAsync(int id)
        {
            try
            {
                var vCliente = await _context.Clientes.FindAsync(id);
                return vCliente != null
                    ? clsOperationResult.SuccessResult("Cliente por id obtenido correctamente.", vCliente)
                    : clsOperationResult.FailureResult("No se encontro el cliente con el id especificado.");
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al obtener el cliente:" + ex.Message);
            }
           
        }
        public async Task<clsOperationResult> AddAsync(clsCliente entity)
        {
            try
            {
                if (entity == null) return clsOperationResult.FailureResult("El cliente no puede ser nulo.");
                await _context.Clientes.AddAsync(entity);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Cliente agregado correctamente.", entity);
            }
            catch (Exception ex)
            {

                return clsOperationResult.FailureResult("Error al agregar un cliente: " + ex.Message);
            }
        }
        public async Task<clsOperationResult> UpdateAsync(clsCliente entity)
        {
            try
            {
                var vCliente = await _context.Clientes.FindAsync(entity.Id);
                if(vCliente == null) return clsOperationResult.FailureResult("El cliente no existe.");
                _context.Clientes.Update(vCliente);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("Cliente actualizado correctamente.", entity);
            }
            catch (Exception ex)
            {
                return clsOperationResult.FailureResult("Error al actualizar un cliente: " + ex.Message);
            }
        }

        public async Task<clsOperationResult> DeleteAsync(int id)
        {
            try
            {
                var vCliente = await _context.Clientes.FindAsync(id);
                if (vCliente == null) return clsOperationResult.FailureResult("El cliente no existe.");
                _context.Clientes.Remove(vCliente);
                await _context.SaveChangesAsync();
                return clsOperationResult.SuccessResult("El cliente fue eliminado correctamente.");

            }
            catch (Exception ex)
            {
                return clsOperationResult.FailureResult("Error al eliminar un clinete: " + ex.Message);
                throw;
            }
            
        }

        
    }
}
