﻿using Composite.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Class
{
    public class Leaf : IComponet
    {
        public void ExeCute()
        {
            Console.WriteLine("Leaf");
        }
    }
}
