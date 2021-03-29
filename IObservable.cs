using System;

public interface IObservable
{
	public delegate void NotifyPropertyChanged(object notifyer, string propertyName);
	public event NotifyPropertyChanged listeners;
}
