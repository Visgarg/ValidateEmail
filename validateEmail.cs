﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidateEmail
{
    class validateEmail
    {
        string pattern = @"^([a-zA-Z]{3,})\@([a-zA-Z0-9])+\.()$";
        public bool IsValidMail(string sample)
        {
          return  Regex.IsMatch(sample, pattern);
        }

    }
}
