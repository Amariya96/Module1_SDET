﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.ExceptionsClass
{
    internal class OrderException : Exception
    {
        public OrderException(string message) : base(message)
        {
        }
    }
}
