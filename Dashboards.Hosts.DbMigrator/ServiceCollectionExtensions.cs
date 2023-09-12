﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Dashboards.Hosts.DbMigrator
{
    /// <summary>
    /// Методы расширения для добавления сервисов.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Добавление сервисов.
        /// </summary>
        /// <param name="services">Сервисы.</param>
        /// <param name="configuration">Конфигурация.</param>
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureDbConnections(configuration);
            return services;
        }

        /// <summary>
        /// Конфигурация подключения к БД.
        /// </summary>
        private static IServiceCollection ConfigureDbConnections(this IServiceCollection services, IConfiguration configuration)
        {
            //var connectionString = configuration.GetConnectionString("PostgresBoardDb");

            //TODO
            var connectionString = "Host=localhost;Database=Board;Username=postgres;Password=password";

            services.AddDbContext<MigrationDbContext>(options => options.UseNpgsql(connectionString));
            return services;
        }
    }
}