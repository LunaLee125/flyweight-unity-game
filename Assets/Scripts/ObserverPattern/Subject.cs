using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    //keeps track of all the observers
    private List<IObserver> _observers = new List<IObserver>();

    public void AddObserver(IObserver observer) {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer) {
        _observers.Remove(observer);
    }

    //notifies each observer
    protected void NotifyObservers(char turn) {
        _observers.ForEach((_observer) => {
            _observer.OnNotify(turn);
        });
    }
}
