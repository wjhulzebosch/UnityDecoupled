using System;
using System.Collections.Generic;
using UnityEngine;

public class World
{
    bool antCreated = false;
    List<Ant> ants;

    public World()
    {
        ants = new List<Ant>();
    }


    internal void Update(float deltaTime)
    {
        //Debug.Log("World is updating...");

        // Creation of an ant from the model
        if(antCreated == false)
        {
            // Create a new ant
            ants.Add(GameController.Instance.GetAntManager().CreateAnt());
            antCreated = true;
        }
        
        foreach(Ant ant in ants)
        {
            ant.Update(deltaTime);
        }
    }
}
