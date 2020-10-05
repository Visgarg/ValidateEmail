using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ValidateEmail
{
    class validateEmail
    {
        string pattern = @"^([a-z]{1})([a-z0-9])*[_.+-]?([a-z0-9])+\@([a-zA-Z0-9])+\.(com|net)$";
        // ask doubt about vg@gmail.com, i want to make id of v@capgemini.com--> which is not happening because of + at last, i want to make + compulsory only if there is special character.
        public bool IsValidMail(string sample)
        {
          return  Regex.IsMatch(sample, pattern);
        }

    }
}
