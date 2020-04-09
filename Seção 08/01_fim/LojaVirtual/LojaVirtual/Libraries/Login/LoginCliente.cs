using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LojaVirtual.Libraries.Sessao;
namespace LojaVirtual.Libraries.Login
{
    public class LoginCliente
    {
        private Sessao.Sessao _sessao;
        public LoginCliente(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }

        private string key = "LoginCliente";
        public void Login(Cliente cliente)
        {
            string clienteString = JsonConvert.SerializeObject(cliente);
            _sessao.Cadastrar(key, clienteString);
        }
        public Cliente GetCliente()
        {
            if (_sessao.Existe(key))
            {
                string clienteString = _sessao.Consultar(key);
                return JsonConvert.DeserializeObject<Cliente>(clienteString);
            }
            else
            {
                return null;
            }
        }
        public void Logout()
        {
            _sessao.RemoverTodos();
        }
    }
}
