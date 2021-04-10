using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace APEx1
{
    public class Model 
    {
        private List<string> data;
        private string[] arrData;

        private int startPoint; 
        private bool run;

        public event NotifyPropertyChanged observe;

		public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
        //IObservable
        //public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
        //public event NotifyPropertyChanged listeners;

        public Model()
        {
            this.data = new List<string>();
            line = 0;
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
            try
            {
                arrData = File.ReadAllLines(name);
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
                // Int32 port = 5400;
                TcpClient client = new TcpClient("127.0.0.1", 5400);
                NetworkStream stream = client.GetStream();

                this.line = this.startPoint;
                ProbCalc pc = new ProbCalc(1);
                Datacollector dc = new Datacollector(this, pc);
                while (run)
                {
                    if (this.line >= arrData.Length - 1)
                    {
                        run = false;
                    }
                    // Encode the data string into a byte array.  
                    byte[] msg = Encoding.ASCII.GetBytes(arrData[line] + "\n");
                    stream.Write(msg, 0, msg.Length);
                   
             //       Thread t = new Thread(new ThreadStart(dc.updateData(arrData[i])));
             //       t.Start();
                    // dc.updateData(arrData[i]);
                    this.line++;

                    System.Threading.Thread.Sleep(frequency);
                }

                // Close everything.
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                System.Threading.Thread.Sleep(10000);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////
        private int line;
        public int PLine
        {
            get
            {
                return line;
            }
            set
            {
                line = value;
            }
        }

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

        private int frequency;
        public int PFrequency
        {
            get
            {
                return frequency;
            }
            set
            {
                frequency = value;
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
        private string path;
        public string PPath
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
                play(1, 0);
            }
        }

    }

    
    public class ProbCalc
	{
		private int numberOfRows;
		private int choosenData;
		private double[] data = new double[42];
		private double[] squareData = new double[42];
		private double[] multData = new double[42];
		private double[] avr = new double[42];

		public ProbCalc(int i_choosenData)
		{
			this.numberOfRows = 0;
			if (i_choosenData < 0 || i_choosenData > 41)
			{
				this.choosenData = 0;
			} 
            else
            {
				this.choosenData = i_choosenData;
            }
			for (int i = 0; i < 42; i++)
			{
				data[i] = 0;
				multData[i] = 0;
				squareData[i] = 0;
			}
		}

		public void addLine(float[] line)
        {
			numberOfRows++;
			for (int i = 0; i < 42; i++)
            {
				float t = line[i];
				multData[i] += t * line[choosenData];
				squareData[i] = t * t;
				data[i] += t;
				//avr[i] = data[i] / numberOfRows; 
            }
        }

		public double getAvg(int x)
        {
			if (x < 0 || x > 41)
            {
				return -1;
            } 
			else
            {
				return avr[x];
            }
        }

		public int gerCurData()
        {
			double[] variance = new double[42];
			for (int i = 0; i < 42; i++)
			{
				avr[i] = data[i] / numberOfRows; //this is the expectation
				variance[i] = (squareData[i] / numberOfRows) - avr[i] * avr[i]; //variance = E[x^2]-E[x]^2 
			}

			double[] covariance = new double[42];; 
			double[] pearson = new double[42];;

			for (int i = 0; i < 42; i++)
			{
				covariance[i] = (multData[i] / numberOfRows) - avr[i] * avr[choosenData]; //covariance = E[xy]-E[x]E[y] 
				pearson[i] = covariance[i] / Math.Sqrt(variance[i] * variance[choosenData]);
			}

			pearson[choosenData] = 0;
			double maxVal = 0;
			int maxIndex = 0;
			for (int i = 0; i < 42; i++)
			{
				if (pearson[i] > maxVal)
                {
					maxVal = pearson[i];
					maxIndex = i;
                }
			}
			return maxIndex; 
		}
	}
}

