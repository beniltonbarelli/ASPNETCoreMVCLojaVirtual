﻿using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaVirtual.Repositories.Contracts
{
    interface IColaboradorRepository
    {
        void Cadastrar(Colaborador colaborador);

        void Atualizar(Colaborador colaborador);

        void Excluir(int id);

        Colaborador ObterColaborador(int id);

        IEnumerable<Colaborador> ObterTodosColaboradores();
    }
}
