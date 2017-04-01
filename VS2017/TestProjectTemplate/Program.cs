﻿using System;
using System.Reflection;
using TinyCLRTest;

namespace $safeprojectname$
{
    class Program
    {
        public static void Main()
        {
            // Run all tests in current assembly
            TestManager.RunTests(Assembly.GetExecutingAssembly());
            
            // Run all tests for specified Test Class
            //TestManager.RunTest(typeof(UnitTest1));

            // Run specified test for specified Test Class
            //TestManager.RunTest(typeof(UnitTest1), "TestMethod1");
        }
    }
}
