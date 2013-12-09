﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kcsara.Database.Web
{
    public class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(string message)
            : base(message)
        {
        }
    }
}