using System;

public class ViewModel : IObservable {
	
	private Model _model; 

	public ViewModel(Model model)
	{
		this._model = model;
	}
	
	public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
	public event NotifyPropertyChanged listeners;

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