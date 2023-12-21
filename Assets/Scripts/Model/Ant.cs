using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant
{
    public Vector2 position;

    public Action<Ant>? onAntUpdated;


    internal void Update(float deltaTime)
    {
        // Slowly move up
        position.y += 0.5f * deltaTime;
        if(onAntUpdated != null)
        {
            onAntUpdated(this);
        }
    }

    #region Callbacks
    public void RegisterCallback(Action<Ant> callback)
    {
        onAntUpdated += callback;
    }

    public void UnregisterCallback(Action<Ant> callback)
    {
        onAntUpdated -= callback;
    }
    #endregion
}
