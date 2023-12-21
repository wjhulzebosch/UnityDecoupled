using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    private Game world;
    private AntManager antManager;

    private void Awake()
    {
        Instance = this;
        world = new Game();
    }
    
    void Update()
    {
        world.Update(Time.deltaTime);
    }
}
