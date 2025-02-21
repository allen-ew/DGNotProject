using DgNotification.DataAccess.Models;
using DgNotification.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Interfaces.Repository
{
    public interface IClienteRepository : IGenericRepository<clsCliente>
    {
        Task<clsOperationResult> CambiarEstado(int id, bool estado);
    }
}
