using DgNotification.DataAccess.Enums;
using DgNotification.DataAccess.Models;
using DgNotification.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Interfaces.Services
{
    public interface INotificacionService : IGenericService<clsNotificacion>
    {
        Task<clsOperationResult> CambiarEstado(int id, NotificacionEstado prmEstado);
    }
}
