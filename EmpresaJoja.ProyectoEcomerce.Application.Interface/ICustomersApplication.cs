using System;
using System.Collections.Generic;
using System.Text;
using EmpresaJoja.ProyectoEcomerce.Application.DTO;
using EmpresaJoja.ProyectoEcomerce.Transversal.Common;
using System.Threading.Tasks;

namespace EmpresaJoja.ProyectoEcomerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Sincrono
        Response<bool> Insert(CustomersDto CustomersDto);
        Response<bool> Update(CustomersDto CustomersDto);
        Response<bool> Delete(string customersId);
        Response<CustomersDto> Get(string customerId);
        Response<IEnumerable<CustomersDto>> GetAll();
        #endregion

        #region Asincrono
        Task<Response<bool>> InsertAsync(CustomersDto CustomersDto);
        Task<Response<bool>> UpdateAsync(CustomersDto CustomersDto);
        Task<Response<bool>> DeleteAsync(string customersId);
        Task<Response<CustomersDto>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();
        #endregion
    }
}
