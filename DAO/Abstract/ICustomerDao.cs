﻿using Core.DataAcess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Abstract
{
    public interface ICustomerDao:IEntityRepository<Customer> 
    {
        //Specifying the operations for Customer table
    }
}
