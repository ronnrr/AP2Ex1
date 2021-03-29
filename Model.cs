using System;

public class Model : AbstractModel
{
    //IObservable
    public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
    public event NotifyPropertyChanged listeners;

    public void play(int frequency, int startPoint) 
    {
    
    }
    public void pause()
    {

    }

    public void loadFile(string name)
    {

    }

    // plane data
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
