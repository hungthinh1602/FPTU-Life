using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleIoC.Implement;
using SimpleIoC.Interface;
using SimpleIoC.Mock;

namespace SimpleIoC
{
    class Program
    {
        static void Main(string[] args)
        {
            //Với mỗi Interface, ta define một Module tương ứng
            DIContainer.SetModule<IDatabase, Database>();
            DIContainer.SetModule<ILogger, Logger>();
            DIContainer.SetModule<IEmailSender, EmailSender>();

            DIContainer.SetModule<Cart, Cart>();

            //DI Container sẽ tự inject Database, Logger vào Cart
            var myCart = DIContainer.GetModule<Cart>();
            myCart.Checkout(1, 100);

            //Khi cần thay đổi, ta chỉ cần sửa code define
            //DIContainer.SetModule<IDatabase, XMLDatabase>();

            //var myCart = new Cart(new Database(), new Logger(), new EmailSender());
            //Khi cần thay đổi database, logger
            //myCart = new Cart(new XMLDatabase(), new FakeLogger(), new FakeEmailSender());
        }
    }

   
}
