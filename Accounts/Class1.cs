using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class User_Accounts
    {
        public int age; //если не определно модификаторов то по умолчанию стоит модификатор private 
        protected string name;
        protected string horda; //наследование horda
        internal string name1;
        protected internal int age1;//доступность из любого места в проекте
        public void Display()
        {
            Console.WriteLine($"{age}\n");
        }

        private class Person_X_24_Account //класс можно определить внутри другого класса и тогда можно использовать для класса модификатор доступа private
        {
            private string password;
            public void User_Accounts_Create()
            {
                User_Accounts user = new User_Accounts();
                user.name1 = "Tom";
                Console.WriteLine(user.name1);
            }
        }
        public class X_24_Account_User : User_Accounts //класс можно определить внутри другого класса и тогда можно использовать для класса модификатор доступа private
        {
            private string password;

            public string User_Accounts_Create()
            {
                User_Accounts user = new User_Accounts();
                user.name1 = "Tom";
                return user.name1;
            }
            public void Display_1()
            {
                age1 = 45;
                Console.WriteLine($"{age1}\n");
            }
        }
    } 
}
