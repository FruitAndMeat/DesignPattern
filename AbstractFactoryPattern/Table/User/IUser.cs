﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal interface IUser
    {
        void Insert(User user);
        User GetUser(int id);   
    }
}
