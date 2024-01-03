﻿using Br.Com.FiapInvestiments.Domain.Entidades;

namespace Br.Com.FiapInvestiments.Application.Interfaces
{
    public interface IUserService
    {
        Task Inserir(Usuario usuario);
        Task<Usuario?> FindByUsernameAndPassword(string username, string password);
        Task<IEnumerable<Usuario>> GetUsers();
    }
}
