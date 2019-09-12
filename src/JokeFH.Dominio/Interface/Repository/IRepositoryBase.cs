using System;
using System.Collections.Generic;
using JokeFH.Dominio.Entities;

namespace JokeFH.Dominio.Interface.Repository
{
    public interface IRepositoryBase<Entity>
    {
        void Adicionar(Entity entity);
        Historico GetById(Guid id);
    }
}