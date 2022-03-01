﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicNetCoreClassProject.Interfaces;

namespace BasicNetCoreClassProject.Classes
{
    public class Worker
    {

        public static void CompareValue<T>(List<T> sender) where T : class
        {
            foreach (var item in sender)
            {
                if (item is IBase data)
                {
                    Debug.WriteLine(data.Id);
                }

            }
        }

    }

}

