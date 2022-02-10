using System;
using EmpresaJoja.ProyectoEcomerce.Domain.Entity;
using EmpresaJoja.ProyectoEcomerce.Infrastructure.Interface;
using EmpresaJoja.ProyectoEcomerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmpresaJoja.ProyectoEcomerce.Infrastructure.Repository
{
    public class CustomerRepository : ICustomersRepository
    {
        private readonly IConectionFactory _conectionFactory;

        public CustomerRepository(IConectionFactory conectionFactory)
        {
            _conectionFactory = conectionFactory;
        }

        #region Sincronos
        public bool Insert(Customers customers)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomesId", customers.CustomesId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Addres", customers.Addres);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public bool Update(Customers customers)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomesId", customers.CustomesId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Addres", customers.Addres);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }
        public bool Delete(string customersId)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("customersId", customersId);
                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }
        public Customers Get(string customersId)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersById";
                var parameters = new DynamicParameters();
                parameters.Add("customersId", customersId);
                var customer = connection.QuerySingle<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var customers = connection.Query<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;
            }
        }

        #endregion

        #region Asincronos
        public async Task<bool> InsertAsync(Customers customers)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomesId", customers.CustomesId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Addres", customers.Addres);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomesId", customers.CustomesId);
                parameters.Add("CompanyName", customers.CompanyName);
                parameters.Add("ContactName", customers.ContactName);
                parameters.Add("ContactTitle", customers.ContactTitle);
                parameters.Add("Addres", customers.Addres);
                parameters.Add("City", customers.City);
                parameters.Add("Region", customers.Region);
                parameters.Add("PostalCode", customers.PostalCode);
                parameters.Add("Country", customers.Country);
                parameters.Add("Phone", customers.Phone);
                parameters.Add("Fax", customers.Fax);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }
        public async Task<bool> DeleteAsync(string customersId)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("customersId", customersId);
                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);
                return result > 0;

            }
        }
        public async Task<Customers>  GetAsync(string customersId)
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersById";
                var parameters = new DynamicParameters();
                parameters.Add("customersId", customersId);
                var customer = await connection.QuerySingleAsync<Customers>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return customer;
            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var connection = _conectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var customers = await connection.QueryAsync<Customers>(query, commandType: CommandType.StoredProcedure);
                return customers;
            }
        }

        #endregion 

    }
}
