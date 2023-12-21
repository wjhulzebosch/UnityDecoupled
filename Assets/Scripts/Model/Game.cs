using System;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    public static Game Instance;
    bool antCreated = false;
    List<Ant> ants;

    public AntManager AntManager;

    public Game()
    {
        AntManager = new AntManager();
        
        ants = new List<Ant>();
        
        Instance = this;
    }


    internal void Update(float deltaTime)
    {
        //Debug.Log("World is updating...");

        // Creation of an ant from the model
        if(antCreated == false)
        {
            // Create a new ant
            ants.Add(AntManager.CreateAnt());
            antCreated = true;
        }
        
        foreach(Ant ant in ants)
        {
            ant.Update(deltaTime);
        }
    }
}
