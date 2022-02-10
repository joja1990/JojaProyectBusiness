using System;
using EmpresaJoja.ProyectoEcomerce.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace EmpresaJoja.ProyectoEcomerce.Infraestructura.Data
{
    public class ConnectionFactory : IConectionFactory
    {
        private readonly IConfiguration _configuration;
        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("NorthwindConnection");
                sqlConnection.Open();

                return sqlConnection;
            }
        }

    }
}
