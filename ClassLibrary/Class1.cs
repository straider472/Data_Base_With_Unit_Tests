using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Class1
    {
        //Метод, проверяющий наличие пользователя в БД
        public static bool Is_Present(string login, string password)
        {
            var user = new For_ShurickEntities().Users.FirstOrDefault(i => i.Login == login.Trim()
                                                                                && i.Password == password.Trim());
            if (user != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
