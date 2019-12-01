using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject
{
    List<IObserver> observers = new List<IObserver>();

    public void Notify()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            observers[i].OnNotify();
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {

    }
}
