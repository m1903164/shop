﻿using Shop.Data.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Interfeses
{
    interface IAllOrders
    {
        void createOrder(Order order);
    }
}
