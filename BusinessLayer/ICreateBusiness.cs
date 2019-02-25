﻿using CommonObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface ICreateBusiness
    {
        void addBook(List<books> book, List<categories> categories);
        void addCategory(List<categories> categories);
    }
}
