using DgNotification.DataAccess.Models;
using DgNotification.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Interfaces.Services
{
    public interface IClienteService : IGenericService<clsCliente>
    {
        Task<clsOperationResult> CambiarEstado(int id);
    }
}
