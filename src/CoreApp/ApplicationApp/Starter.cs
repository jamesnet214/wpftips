﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            App app = new();
            app.Run();
        }
    }
}
