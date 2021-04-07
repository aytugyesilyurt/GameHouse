using System;
using System.Collections.Generic;
using System.Text;
using GameHouse.Entities;

namespace GameHouse.Abstract.UserOperations.ValidationOperations
{
    public interface IUserValidationService
    {
        // Doğrulama sistemi için interface oluştururuz. Çünkü ileride farklı kimlik doğrulama işlemleri olabilir yada farklı classlarda kimlik doğrulama işlemini kullanabilmek için. Kimlik doğrulama doğru yada yanlış şeklinde 2 cevap olarak geldiği için bool olur.
        bool Validate(User user);
    }
}
