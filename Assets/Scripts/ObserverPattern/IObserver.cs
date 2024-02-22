//implemented by subject class 

public interface IObserver 
{
	public void OnNotify(PlayerTurns x);

	public void OnNotify(EndStates x);
}