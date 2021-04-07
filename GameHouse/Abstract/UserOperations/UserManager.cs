using GameHouse.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using GameHouse.Abstract.UserOperations.ValidationOperations;

namespace GameHouse.Abstract
{
    // Kişi işlemleri yapabilmek için oluşturulan classtır. Interfaceye atanarak imzalar alınır ve içine işlemler yazılır. Kişi işlemleri ile ilgili metot barındırdığı için "manager" olarak isimlendirilmiştir.
    // Burada save işlemi için bir doğrulama sisteminin kullanılması isteniyor. Metot barındıran bir class içinde başka bir metot barındıran bir class kullanılacaksa bu işlem DEPENDENCY INJECTION ile yapılmalıdır.(her seferinde newlememek için) Bu yüzden metot içinde kontrol yapacağımız işlemin interfacesini _kontrolişlemi olarak oluştururuz. Ardından constructor bloğunun girdisi olarak denetleme işlemi yapan interface ve metotu yazarız. Constructor bloğunun içinde doğrulama sistemlerinden gelen örneği eşitleyerek _kontrolişlemi ile devam ederiz.
    public class UserManager : IUserService
    {
        private IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Save(User user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı sisteme başarıyla kaydedildi.");
            }

            else
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " KİŞİ BİLGİLERİ YANLIŞ!\nLÜTFEN BİLGİLERİNİZİ KONTROL EDİNİZ.");
            }
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcının bilgileri sistemde başarıyla güncellendi.");
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " isimli kullanıcı sistemden başarıyla silindi.");
        }


    }
}
