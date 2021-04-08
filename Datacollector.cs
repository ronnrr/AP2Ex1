using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APEx1
{
    class Datacollector
    {
        private Model mod; 
        public Datacollector(Model m)
        {
            this.mod = m;
        }

        // This function get a line from the csv file, 
        // and update the information in the model. 
        public void updateData(string s) 
        {
            try
            {
                char[] a = { ',' };
                string[] arr = s.Split(a);

                mod.PAileron = float.Parse(arr[0]); //aileron
                mod.PElevator = float.Parse(arr[1]); //elevator
                mod.PRudder = float.Parse(arr[2]); //rudder
                mod.PThrottle = float.Parse(arr[6]); //throttle
                mod.PRoll = float.Parse(arr[17]); //roll
                mod.PPitch = float.Parse(arr[18]); //pitch
                mod.PYaw = float.Parse(arr[21]); //yaw
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
    }
}
