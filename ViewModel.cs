using System;

public class ViewModel
{
    // when entering a new file reset hasstopped to false.
    private APEx1.Model _model;

    public ViewModel(APEx1.Model model)
    {
        this._model = model;
    }

    public void playAnimation()
    {
        if (!hasStopped)
        {
            _model.pause();
            _model.play(_frequency, VM_CurrentTime);
        }
    }
    public void pauseAnimation()
    {
        if (!hasStopped)
        {
            _model.pause();
        }
    }
    public void stopAnimation()
    {
        _model.pause();
        hasStopped = true;
    }
    public void playAnimationFrequency(int frequency)
    {
        _model.play(frequency, VM_CurrentTime);
        _frequency = frequency;
        Console.WriteLine("Socket connected to {0}");
    }

    private int currentTime;
    public int VM_CurrentTime
    {
        get { return _model.PLine; }
        set
        {
            currentTime = value;
            _model.pause();
            _model.play(_frequency, currentTime);
        }
    }

    private int _frequency;
    public int VM_Frequency
    {
        get { return _frequency; }
        set
        {
            _frequency = value;
            _model.pause();
            _model.play(_frequency, VM_CurrentTime);
        }
    }

    private bool hasStopped;
    public bool VM_HasStopped
    {
        get { return hasStopped; }
        set
        {
            hasStopped = value;
        }
    }

    public double VM_yaw;
    public double VM_roll;
    public double VM_pitch;
    public double VM_direction;
    public double VM_speed;
    public int VM_height;

    public int VM_aileron;
    public int VM_rudder;
    public int VM_elevator;
    public int VM_throttle;
}