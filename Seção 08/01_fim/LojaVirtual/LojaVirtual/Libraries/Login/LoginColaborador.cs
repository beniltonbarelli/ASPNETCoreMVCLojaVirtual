using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LojaVirtual.Libraries.Sessao;

namespace LojaVirtual.Libraries.Login
{
    public class LoginColaborador
    {
        private string key = "LoginColaborador";

        private Sessao.Sessao _sessao;
        public LoginColaborador(Sessao.Sessao sessao)
        {
            _sessao = sessao;
        }
        
        public void Login(Colaborador colaborador)
        {
            string colaboradorString = JsonConvert.SerializeObject(colaborador);
            _sessao.Cadastrar(key, colaboradorString);
        }
        public Colaborador GetColaborador()
        {
            if (_sessao.Existe(key))
            {
                string colaboradorString = _sessao.Consultar(key);
                return JsonConvert.DeserializeObject<Colaborador>(colaboradorString);
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
