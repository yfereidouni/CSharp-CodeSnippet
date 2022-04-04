﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iConcurrencyAndAsynchrony.ThreadSample
{
    public class CharPrinter
    {
        public void PrintStar()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("*");
                //Thread.Sleep(50);
                Thread.Yield();
            }
        }
        public void PrintDash()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("-");
                //Thread.Sleep(50);
                Thread.Sleep(0);
            }
            //Console.WriteLine($"{Thread.CurrentThread.Name} isAlive after start : {Thread.CurrentThread.IsAlive}");
        }
    }
}
