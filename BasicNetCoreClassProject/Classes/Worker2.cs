using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicNetCoreClassProject.Interfaces;

namespace BasicNetCoreClassProject.Classes
{
    public class Worker2
    {

        public static void CompareValue<T>(List<T> sender) where T : class, IBase
        {
            foreach (var item in sender)
            {
                Debug.WriteLine(item.Id);
            }
        }

    }

}

