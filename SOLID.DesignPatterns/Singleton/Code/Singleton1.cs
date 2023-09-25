﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DesignPatterns.Singleton.Code
{
    public sealed class Singleton
    {
        #region Singleton implementation using static constructor
        private static readonly Singleton Instance;
        private static int TotalInstances;
        /*
        * Private constructor is used to prevent
        * creation of instances with the 'new' keyword
        * outside this class.
        */
        private Singleton()
        {
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine("--Exit now from private constructor.");
        }
        /*
        * A static constructor is used for the following purposes:
        * 1. To initialize any static data
        * 2. To perform a specific action only once
        *
        * The static constructor will be called automatically before:
        * i. You create the first instance; or
        * ii.You refer to any static members in your code.
        *
        */

        // Here is the static constructor
        static Singleton()
        {
            // Printing some messages before you create the instance
            Console.WriteLine("-Static constructor is called.");
            Instance = new Singleton();
            TotalInstances++;
            Console.WriteLine($"-Singleton instance is created.Number of instances:{ TotalInstances}");
        Console.WriteLine("-Exit from static constructor.");
        }
        public static Singleton GetInstance
        {
            get
            {
                return Instance;
            }
        }
        /*
        * If you like to use expression-bodied read-only
        * property, you can use the following line (C# v6.0 onwards).
        */
        // public static Singleton GetInstance => Instance;
        #endregion
        /* The following line is used to discuss
        the drawback of the approach. */
        public static int MyInt = 25;
    }
}