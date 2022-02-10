using APIClientes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIClientes.Repositorio
{
    public interface IUserRepositorio
    {
        Task<int> Registrer(User user, string password);
        Task<string> Login(string UserName, string password);
        Task<bool> UserExiste(string UserName);
    }
}
