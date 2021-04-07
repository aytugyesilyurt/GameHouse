using System;
using System.Collections.Generic;
using System.Text;
using GameHouse.Entities;

namespace GameHouse.Abstract
{
    // Kişi işlemlerini düzenleyebilmek için SOYUT basamak. Önce işlemlerin yapılacağı imzalar interface içine yazılır ardından bu interfaceyi atayarak içine metotlar yazacağımız classı oluştururuz. SOYUT olarak yazdığımız interfacelerin adları genellikle "service" olur. Metotların yazıldığı class isimlerini ise "manager" olarak adlandırabiliriz.
    public interface IUserService
    {
        void Save(User user);
        void Update(User user);
        void Delete(User user);
    }
}
