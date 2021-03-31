using System;
using System.Collections.Generic;
using System.Text;

namespace GameHouse
{
    class CustomerManagerService
    {
        public void SignIn(CustomerManager customer)
        {

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " isimli üyelik oluşturuldu.");
        }

        public void Update(CustomerManager customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " isimli üyelik başarıyla güncellendi.");
        }

        public void Delete(CustomerManager customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " isimli üyelik sistemden silindi.");
        }
    }
}
