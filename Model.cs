using System;
using System.Io;
using System.Threading;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;



public class Model : AbstractModel
{
    private string fileName;
    private List<string> data;
    private string[] arrData;
    private bool run; 

    //IObservable
    public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
    public event NotifyPropertyChanged listeners;

    public Model() 
    {
        this.data = new List<string>();
    }

    public void play(int frequency, int startPoint) 
    {
        run = true;
        //Thread t = new Thread();
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
                data.Add(new string(line));
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
            arrData = data.ToArray();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            sr.Close();
            Console.WriteLine("Executing finally block.");
        }
    }

    public trasmitData(int frequency, int startPoint)
    {
        try
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 8081);
            
            // Create a TCP/IP socket.  
            Socket client = new Socket(ipAddress.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);
            
            client.BeginConnect(remoteEP, new AsyncCallback(ConnectCallback), client);
            connectDone.WaitOne();

            int i = startPoint;
            Thread t = new Thread(delegate() { 
                    Send(client, this.arrData[i++]);
                });

            while (run)
            {
                if (i >= arrData.Length())
                {
                    run = false;
                }
                t.Start();
                t.Join();
                t.Interrupt(100);
            }
        } 
        catch
        {
            Console.WriteLine("An error in the massage sending to FG :-(");
        }
    }

    /*
     * aileron
     * elevator
     * rudder
     * flaps -----
     * slats -----
     * speedbrake ------
     * throtle
     * 
     * */


    // airplane data
    public double yaw { }
    public double roll { }
    public double pitch { }
    public double direction { }
    public double speed { }
    public int hight { }

    // joystick data
    public int aileron { }
    public int rudder { }
    public int elevator { }
    public int throttle { }

}
