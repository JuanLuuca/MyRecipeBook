﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeBook.Communication.Requests
{
    public class RequestRegisterUserJson
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
