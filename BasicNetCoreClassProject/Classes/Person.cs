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
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public override string ToString() => $"{Id,-5}{First_Name} {Last_Name}";
    }

}
