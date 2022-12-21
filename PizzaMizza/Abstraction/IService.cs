using System;
namespace PizzaMizza.Abstraction
{
    interface IService<T>
    {
        #region
        //void Add(T model);

        //void Delete(int Id);

        //T GetById(int Id);

        //List<T> GetAll();

        //void Update(T model);
        #endregion
        void Add(T model);

        void Delete(int Id);

        T GetById(int Id);

        List<T> GetAll();

        void Update(T model);

    }
}

