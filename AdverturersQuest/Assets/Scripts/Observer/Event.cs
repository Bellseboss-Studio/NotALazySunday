using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;


[CreateAssetMenu(fileName = "New Event", menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> eListeners = new List<EventListener>();

    public void Register(EventListener listerner)
    {
        eListeners.Add(listerner);
    }

    public void Unregister(EventListener listerner)
    {
        eListeners.Remove(listerner);
    }

    public void Occurred()
    {
        for (int i = 0; i < eListeners.Count; i++)
        {
            eListeners[i].OnEventOccurs();
        }
    }
}

