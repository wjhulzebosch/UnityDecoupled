using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AntManager
{
    // Callbacks
    public event Action<Ant>? onAntCreatedCallback;
    public AntManager()
    {
        Debug.Log("AntManager created!");
    }

    public Ant CreateAnt()
    {
        Ant newAnt = new Ant();
        if(onAntCreatedCallback != null)
        {
            onAntCreatedCallback(newAnt);
        }

        return newAnt;
    }

    #region Callbacks
    public void RegisterCallback(Action<Ant> callback)
    {
        onAntCreatedCallback += callback;
    }

    public void UnregisterCallback(Action<Ant> callback)
    {
        onAntCreatedCallback -= callback;
    }


    #endregion
}
