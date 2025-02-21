using DgNotification.DataAccess.Enums;
using DgNotification.DataAccess.Interfaces.Repository;
using DgNotification.DataAccess.Interfaces.Services;
using DgNotification.DataAccess.Models;
using DgNotification.DataAccess.Repositories;
using DgNotification.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.DataAccess.Services
{
    public class clsNotificacionService : INotificacionService
    {
        private readonly INotificacionRepository _notificacionRepository;
        public clsNotificacionService(INotificacionRepository notificacionRepository)
        {
            _notificacionRepository = notificacionRepository;
        }

        public async Task<clsOperationResult> ObtenerPorIdAsync(int id)
        {
            return await _notificacionRepository.GetByIdAsync(id);
        }

        public async Task<clsOperationResult> ObtenerTodosAsync()
        {
            return await _notificacionRepository.GetAllAsync();
        }
        public async Task<clsOperationResult> AgregarAsync(clsNotificacion entity)
        {
            var vNotificacion = new clsNotificacion
            {
                ClienteId = entity.ClienteId,
                MedicamentoId = entity.MedicamentoId,
                FechaNotificacion = entity.FechaNotificacion,
                Estado = entity.Estado
            };

            return await _notificacionRepository.AddAsync(vNotificacion);
        }

        public async Task<clsOperationResult> ActualizarAsync(clsNotificacion entity)
        {
            var vNotificacion = new clsNotificacion
            {
                ClienteId = entity.ClienteId,
                MedicamentoId = entity.MedicamentoId,
                FechaNotificacion = entity.FechaNotificacion,
                Estado = entity.Estado
            };

            return await _notificacionRepository.UpdateAsync(vNotificacion);
        }

        public Task<clsOperationResult> EliminarAsync(int id)
        {
            return _notificacionRepository.DeleteAsync(id);
        }
        public async Task<clsOperationResult> CambiarEstado(int id, NotificacionEstado prmEstado)
        {
            var vNotificacion = await _notificacionRepository.GetByIdAsync(id);

            if (vNotificacion.Data is clsNotificacion vNotificacionData)
            {
                return await _notificacionRepository.CambiarEstado(id, prmEstado);
            }

            return vNotificacion;
        }



    }
}
