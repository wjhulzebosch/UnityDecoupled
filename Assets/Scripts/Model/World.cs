using System;
using UnityEngine;

public class World
{
    bool antCreated = false;

    internal void Update(float deltaTime)
    {
        Debug.Log("World is updating...");

        if(antCreated == false)
        {
            // Create a new ant
            GameController.Instance.GetAntManager().CreateAnt();
        }
    }
}
