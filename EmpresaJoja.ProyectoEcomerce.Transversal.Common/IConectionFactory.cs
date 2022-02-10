using System.Data;

namespace EmpresaJoja.ProyectoEcomerce.Transversal.Common
{
    public interface IConectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}
