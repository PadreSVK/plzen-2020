using System;

namespace Basics
{
    public class Dynamic : ISample
    {
        public void Run()
        {
            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = System.DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();


            //int i = d1;
            //string str = d2;
            //DateTime dt = d3;
            //System.Diagnostics.Process[] procs = d4;
        }
    }
}