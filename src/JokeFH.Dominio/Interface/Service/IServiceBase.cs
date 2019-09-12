using System;

namespace JokeFH.Dominio.Interface.Service
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
    }
}