﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Organization.Employees
{
    interface ISalary
    {
        void AddSalary();

        void AddSalary(Employee headOfDepartment);
    }
}
