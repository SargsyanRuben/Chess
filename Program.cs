using System;
using System.Globalization;
using System.Linq.Expressions;

namespace SHAXMAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users users = new Users();
            while (true)
            {
                users.User1();
                users.User2();
            }
            
        }
    }
}