using DgNotification.DataAccess;
using DgNotification.DataAccess.Interfaces.Repository;
using DgNotification.DataAccess.Interfaces.Services;
using DgNotification.DataAccess.Models;
using DgNotification.DataAccess.Repositories;
using DgNotification.DataAccess.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Windows.Forms;
namespace DgNotification
{
    public static class Program
    {
        // ...

        [STAThread]
        static void Main()
        {
            // Inicializar la configuración de Windows Forms para que pueda funcionar correctamente
            ApplicationConfiguration.Initialize();

            //Configuracion DI y HostBuilder
            using var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Cargar configuración desde appsettings.json
                    var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .Build();

                    // Obtener la cadena de conexión
                    string? connectionString = config.GetConnectionString("DGNotDDBB");

                    if (connectionString == null)
                    {
                        throw new InvalidOperationException("La cadena de conexión no puede ser nula.");
                    }

                    // Agregar Entity Framework con SQL Server
                    services.AddDbContext<clsDGNotiDBContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Registrar Repositorios
                    services.AddScoped<IClienteRepository, clsClienteRepository>();
                    services.AddScoped<ICompraRepository, clsCompraRepository>();
                    services.AddScoped<IMedicamentoRepository, clsMedicamentoRepository>();
                    services.AddScoped<IMedicamentoFrecuenciaRepository, clsMedicamentoFrecuenciaRepository>();
                    services.AddScoped<INotificacionRepository, clsNotificacionRepository>();

                    // Registrar Servicios
                    services.AddScoped<IClienteService, clsClienteService>();
                    services.AddScoped<ICompraService, clsCompraService>();
                    services.AddScoped<IMedicamentoService, clsMedicamentoService>();
                    services.AddScoped<IMedicamentoFrecuenciaService, clsMedicamentoFrecuenciaService>();
                    services.AddScoped<INotificacionService, clsNotificacionService>();

                    // Registrar el formulario principal
                    services.AddScoped<FormMain>();
                })
                .Build();

            var form1 = host.Services.GetRequiredService<FormMain>();

            Application.Run(form1);
        }


    }
}