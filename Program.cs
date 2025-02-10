using DgNotification.DataAccess;
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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
                    string connectionString = config.GetConnectionString("DGNotDDBB");

                    // Agregar Entity Framework con SQL Server
                    services.AddDbContext<clsDGNotiDBContext>(options =>
                        options.UseSqlServer(connectionString));

                    // Registrar servicios

                    // Registrar el formulario principal
                    services.AddScoped<Form1>();
                })
                .Build();


            var form1 = host.Services.GetRequiredService<Form1>();
   
            Application.Run(form1);



        }


    }
}