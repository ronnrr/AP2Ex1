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
        private ProbCalc pc;
        public Datacollector(Model m, ProbCalc p)
        {
            this.mod = m;
            this.pc = p;
        }

        // This function get a line from the csv file, 
        // and update the information in the model. 
        public void updateData(string s) 
        {
            try
            {
                float[] properties = new float[50]; 
                char[] chars = { ',' };
                string[] arr = s.Split(chars);

                int end = arr.Length;
                for (int i = 0; i < end; i++)
                {
                    properties[i] = float.Parse(arr[i]);
                }
                pc.addLine(properties);

                mod.PAileron = properties[0]; //aileron
                mod.PElevator = properties[1]; //elevator
                mod.PRudder = properties[2]; //rudder
                mod.PThrottle = properties[6]; //throttle
                mod.PRoll = properties[17]; //roll
                mod.PPitch = properties[18]; //pitch
                mod.PYaw = properties[21]; //yaw
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
    }
}
