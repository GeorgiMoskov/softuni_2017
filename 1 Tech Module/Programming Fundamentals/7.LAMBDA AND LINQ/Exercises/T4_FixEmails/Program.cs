using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailDB = new Dictionary<string, string>();

            var firstLine = Console.ReadLine();

            do
            {
                if (firstLine != "stop")
                {
                    var name = firstLine;
                    var email = Console.ReadLine();

                    var emailDomain = String.Join("",email.Skip(email.Length - 2)).ToLower();
                   
                    if (!(emailDomain == "us" || emailDomain == "uk"))
                    {
                        emailDB[name] = email;
                    }


                }
                else
                {
                    foreach (var item in emailDB)
                    {
                        Console.WriteLine("{0} -> {1}", item.Key, item.Value);
                    }

                    return;
                }
                firstLine = Console.ReadLine();
            } while (true);

        }
    }
}
