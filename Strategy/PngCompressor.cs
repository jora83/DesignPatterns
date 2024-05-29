﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string FileName)
        {
            Console.WriteLine("Compressing using PNG.");
        }
    }
}
