using System;

namespace HomeWork_02._21._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("sadig0v_1","Isa2002");
            //Console.WriteLine(user.GetInfo());

            //Admin admin = new Admin("sadig0v_1", "Isa2002",true,"asdf");
            //Console.WriteLine(admin.getInfo());

            //User user = new User("sadigov","asdfg123");
            ////Console.WriteLine(user.GetInfo());
            //user.setUsername("sa");
            ////user.setPassword("asdfggh");
            //Console.WriteLine(user.GetInfo());

            Admin admin = new Admin("sa","123456",false,"add");
            Console.WriteLine(admin.GetInfo());
        }
    }
}
