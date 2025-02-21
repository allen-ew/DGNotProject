using DgNotification.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<clsOperationResult> GetAllAsync();
        Task<clsOperationResult> GetByIdAsync(int id);
        Task<clsOperationResult> AddAsync(T entity);
        Task<clsOperationResult> UpdateAsync(T entity);
        Task<clsOperationResult> DeleteAsync(int id);
    }
}
