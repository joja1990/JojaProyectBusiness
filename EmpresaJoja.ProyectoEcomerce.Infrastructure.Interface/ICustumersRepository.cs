using System;
using System.Collections.Generic;
using System.Text;
using EmpresaJoja.ProyectoEcomerce.Domain.Entity;
using System.Threading.Tasks;

namespace EmpresaJoja.ProyectoEcomerce.Infrastructure.Interface
{
    public interface ICustomersRepository
    {
        #region Sincrono
        bool Insert(Customers customers);
        bool Update(Customers customers);
        bool Delete(string customersId);
        Customers Get(string customerId);
        IEnumerable<Customers> GetAll();
        #endregion

        #region Asincrono
        Task<bool> InsertAsync(Customers customers);
        Task<bool> UpdateAsync(Customers customers);
        Task<bool> DeleteAsync(string customersId);
        Task<Customers> GetAsync(string customerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        #endregion
    }
}
