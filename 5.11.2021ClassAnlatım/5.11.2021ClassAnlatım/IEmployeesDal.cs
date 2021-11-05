using System;
using System.Collections.Generic;
using System.Text;

namespace _5._11._2021ClassAnlatım
{
    public interface IEmployeesDal
    {
        void Listele(Employees employees);
        void Ekle(Employees employees);
    }
}
