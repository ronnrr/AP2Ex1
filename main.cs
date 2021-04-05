using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace APEx1
{
    class program
    {
        /*public static void Main(string[] args)
        {
            Model m = new Model();
            m.observe += func;
            m.loadFile("reg_flight.csv");
            m.play(100, 1);

            //System.Threading.Thread.Sleep(3000);
            //m.pause();
        }*/

        public static void func(object notifyer, string propertyName)
        {
            Console.WriteLine(propertyName + " has changed!");
        }
    }
}
