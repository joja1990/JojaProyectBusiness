using System;
using EmpresaJoja.ProyectoEcomerce.Domain.Entity;
using EmpresaJoja.ProyectoEcomerce.Domain.Interface;
using EmpresaJoja.ProyectoEcomerce.Infrastructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmpresaJoja.ProyectoEcomerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersDomain(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;

        }

        #region Metosdos sincronos
        public bool Insert(Customers customers)
        {
            return _customersRepository.Insert(customers);
        }
        public bool Update(Customers customers)
        {
            return _customersRepository.Update(customers);
        }
        public bool Delete(string customersId)
        {
            return _customersRepository.Delete(customersId);
        }
        public Customers Get(string customersId)
        {
            return _customersRepository.Get(customersId);
        }
        public IEnumerable<Customers> GetAll()
        {
            return _customersRepository.GetAll();
        }

        #endregion

        #region Metosdos Asincronos
        public async Task<bool> InsertAsync(Customers customers)
        {
            return await _customersRepository.InsertAsync(customers);
        }
        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customersRepository.UpdateAsync(customers);
        }
        public async Task<bool> DeleteAsync(string customersId)
        {
            return await _customersRepository.DeleteAsync(customersId);
        }
        public async Task<Customers> GetAsync(string customersId)
        {
            return await _customersRepository.GetAsync(customersId);
        }
        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customersRepository.GetAllAsync();
        }

        #endregion

    }
}
