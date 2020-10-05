using System;

namespace ValidateEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please write an email to validate");
                string sample = Console.ReadLine();
                validateEmail validateEmail = new validateEmail();
                if (sample == "")
                    break;


                Console.WriteLine(validateEmail.IsValidMail(sample));
            }
        }
    }
}
