using APEx1;
using System;
using System.ComponentModel;
public class ViewModel
{
    // when entering a new file reset hasstopped to false.
    private APEx1.Model _model;
    public event PropertyChangedEventHandler PropertyChanged;
    public void NotifyPropertyChanged(string propName) 
    {
        
    }


    public ViewModel(APEx1.Model model)
    {
        this._model = model;
        model.observe += updateData;
    }

    public void updateData(object notifier, string property)
    {
        switch (property)
        {
            case "line":
                int temp = VM_CurrentTime;
                break;
            case "lineCount":
                int temp1 = VM_MaxTime;
                break;
            default:
                break;
        }
    }
    public void updateCurrentLine(int value)
    {
        _model.PLine = value;
    }
    public void setModelFileName(string file)
    {
        _model.loadFile(file);
        _model.play(100, 1);
        hasStopped = false;
    }
    public void playAnimation()
    {
        if (!hasStopped)
        {
            _model.pause();
            _model.play(_model.PFrequency, VM_CurrentTime);
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
        if (!hasStopped)
        {
            int temp = VM_CurrentTime;
            _model.play(frequency, VM_CurrentTime);
            _model.PFrequency = frequency;
        }
    }

    private int currentTime;
    public int VM_CurrentTime
    {
        get { return _model.PLine; }
        set
        {
            if (currentTime != value)
            {
                _model.PLine = value;
                currentTime = value;
                /*int ca = value;
                currentTime = value;
                _model.PLine = value;
                _model.pause();
                _model.play(VM_Frequency, currentTime);*/
            }
        }
    }


    public int VM_MaxTime
    {
        get
        {
            return _model.PLineCount;
        }
        set
        {
            _model.PLineCount = value;
        }
    }
    public int VM_Line
    {
        get { return _model.PLine; }
        set
        {
            _model.PLine = value;
        }
    }
    public int VM_Frequency
    {
        get { return _model.PFrequency; }
        set
        {
            _model.PFrequency = value;
            _model.pause();
            _model.play(_model.PFrequency, VM_CurrentTime);
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