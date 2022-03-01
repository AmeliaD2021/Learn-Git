using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicNetCoreClassProject.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace BasicNetCoreClassProject.Classes
{
    public class Person : IBase
    {
        public int Identifier { get; set; }
        public int Id => Identifier;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{Id,-5}{FirstName} {LastName}";
    }

}
