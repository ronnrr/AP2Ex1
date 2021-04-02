using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace APEx1
{
    public class Model : IObservable
    {
        private string fileName;
        private List<string> data;
        private string[] arrData;

        private int startPoint; 
        private int frequency;
        private bool run;

        public event NotifyPropertyChanged observe;


        //IObservable
        //public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
        //public event NotifyPropertyChanged listeners;

        public Model()
        {
            this.data = new List<string>();
        }

        public void play(int frequency, int startPoint)
        {
            this.startPoint = startPoint;
            this.frequency = frequency;
            this.run = true;

            Thread t = new Thread(new ThreadStart(this.trasmitData));
            t.Start();
        }

        public void pause()
        {
            run = false;
        }

        public void loadFile(string name)
        {
            this.fileName = name;
            try
            {
                string line;
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(this.fileName);
                line = sr.ReadLine();
                while (line != null)
                {
                    //add the line to the list
                    data.Add(new string(line.ToCharArray()));
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                this.arrData = data.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        //public void trasmitData(int frequency, int startPoint)
        public void trasmitData()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5400);

                // Create a TCP/IP socket.  
                Socket client = new Socket(ipAddress.AddressFamily,
                    SocketType.Stream, ProtocolType.Tcp);
                client.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}",
                     client.RemoteEndPoint.ToString());


                int i = this.startPoint;                

                while (run)
                {
                    if (i >= arrData.Length - 1)
                    {
                        run = false;
                    }
                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(arrData[i]);

                    // Send the data through the socket.  
                    int bytesSent = client.Send(msg);
                    Console.WriteLine(arrData[i]);
                    i++;
                    System.Threading.Thread.Sleep(frequency);
                }

                // Release the socket.  
                //client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            catch (Exception e)
            {   
                Console.WriteLine(e.Message);
                System.Threading.Thread.Sleep(30000);

            }
        }


        /// /////////////////////////////////////////////////////////////////////////////////////

        private float yaw; 
        // plane data
        public float PYaw
        {
            get
            {
                return yaw;
            }
            set
            {
                yaw = value;
                observe(this, "yaw");
            }
        }

        private float roll;
        public float PRoll 
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                observe(this, "roll");
            }
        }

        private float pitch;
        public float PPitch 
        {
            get
            {
                return pitch;
            }
            set
            {
                pitch = value;
                observe(this, "pitch");
            }
        }

        private float direction;
        public float PDirection 
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
                observe(this, "direction");
            }
        }

        private float speed; 
        public float PSpeed 
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                observe(this, "speed");
            }
        }

        private float hight; 
        public float PHight 
        {
            get
            {
                return hight;
            }
            set
            {
                hight = value;
                observe(this, "hight");
            }
        }

        // joystick data
        private float aileron;
        public float PAileron 
        {
            get
            {
                return aileron;
            }
            set
            {
                aileron = value;
                observe(this, "aileron");
            }
        }

        private float rudder;
        public float PRudder 
        {
            get
            {
                return rudder;
            }
            set
            {
                rudder = value;
                observe(this, "rudder");
            }
        }

        private float elevator;
        public float PElevator 
        {
            get
            {
                return elevator;
            }
            set
            {
                elevator = value;
                observe(this, "elevator");
            }
        }

        private float throttle; 
        public float PThrottle 
        {
            get
            {
                return throttle;
            }
            set
            {
                throttle = value;
                observe(this, "throttle");
            }
        }

    }
}
