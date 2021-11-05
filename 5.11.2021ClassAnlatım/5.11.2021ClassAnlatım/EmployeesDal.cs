using System;
using System.Collections.Generic;
using System.Text;

namespace _5._11._2021ClassAnlatım
{

    public class EmployeesDal
    {

        public void Add(Employees employees)
        {
            Console.WriteLine(employees.Name + "sisteme dahil oldu");

        }
        public void Listele(Employees employees)
        {
            Console.WriteLine("ıd:"+employees.Id);
            Console.WriteLine("name:"+employees.Name);
            Console.WriteLine("password:"+employees.Password);
            Console.WriteLine("phone number:"+employees.PhoneNumber);
            Console.WriteLine("soyad:"+employees.Soyad);
        }
    }
}
