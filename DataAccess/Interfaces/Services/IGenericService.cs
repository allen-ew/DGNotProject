using DgNotification.Shared.Helpers;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Interfaces.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<clsOperationResult> ObtenerTodosAsync();
        Task<clsOperationResult> ObtenerPorIdAsync(int id);
        Task<clsOperationResult> AgregarAsync(T entity);
        Task<clsOperationResult> ActualizarAsync(T entity);
        Task<clsOperationResult> EliminarAsync(int id);

    }
}
