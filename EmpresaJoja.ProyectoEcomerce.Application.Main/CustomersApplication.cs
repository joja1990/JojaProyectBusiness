using System;
using AutoMapper;
using EmpresaJoja.ProyectoEcomerce.Application.DTO;
using EmpresaJoja.ProyectoEcomerce.Application.Interface;
using EmpresaJoja.ProyectoEcomerce.Domain.Entity;
using EmpresaJoja.ProyectoEcomerce.Domain.Interface;
using EmpresaJoja.ProyectoEcomerce.Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EmpresaJoja.ProyectoEcomerce.Application.Main
{
    public class CustomersApplication : ICustomersApplication
    {
        private readonly ICustomersDomain _customersDomain;
        private readonly IMapper _mapper;

        public CustomersApplication(ICustomersDomain customersDomain, IMapper mapper)
        {
            _customersDomain = customersDomain;
            _mapper = mapper;
        }
        #region Sincrono
        public Response<bool> Insert(CustomersDto CustomersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(CustomersDto);
                response.Data = _customersDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Registro Exitoso!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<bool> Update(CustomersDto CustomersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(CustomersDto);
                response.Data = _customersDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Actualizacion Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _customersDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Eliminacion Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<CustomersDto> Get(string customerId)
        {
            var response = new Response<CustomersDto>();
            try
            {
                var customer = _customersDomain.Get(customerId);
                response.Data = _mapper.Map<CustomersDto>(customer);
                if (response.Data != null)
                {
                    response.IsSucess = true;
                    response.Message = "Consulta Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public Response<IEnumerable<CustomersDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDto>>();
            try
            {
                var customers = _customersDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customers);
                if (response.Data != null)
                {
                    response.IsSucess = true;
                    response.Message = "Consulta Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        #endregion

        #region Asincrono
        public async Task<Response<bool>> InsertAsync(CustomersDto CustomersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(CustomersDto);
                response.Data = await _customersDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Registro Exitoso!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomersDto CustomersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(CustomersDto);
                response.Data = await _customersDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Actualizacion Exitoso!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _customersDomain.DeleteAsync(customerId);
                if (response.Data)
                {
                    response.IsSucess = true;
                    response.Message = "Eliminacion Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<CustomersDto>> GetAsync(string customerId)
        {

            var response = new Response<CustomersDto>();
            try
            {
                var customer = await _customersDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomersDto>(customer);
                if (response.Data != null)
                {
                    response.IsSucess = true;
                    response.Message = "Consulta Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        public async Task<Response<IEnumerable<CustomersDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDto>>();
            try
            {
                var customers = await _customersDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customers);
                if (response.Data != null)
                {
                    response.IsSucess = true;
                    response.Message = "Consulta Exitosa!!";
                }

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
            }
            return response;
        }
        #endregion
    }
}
