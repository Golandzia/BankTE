using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesWPF
{
    public class User
    {

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Lastame { get; set; }
        public string NumberPhone { get; set; }

        public string Role { get; set; }
        public string Password { get; set; }
        public string NubmerCard { get; set; }

        public string FullInformation { get => FirstName + " : " + MiddleName + " : " + Lastame + " : " + NumberPhone + " : " + Role + " : " + Password + " : " + NubmerCard; set { } }

        public string ShortInformation
        {
            get => FirstName + " : " + MiddleName + " : " + Lastame;

            set { }
        }
    }
}
