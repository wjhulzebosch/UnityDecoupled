using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    private World world;
    private AntManager antManager;
    // Start is called before the first frame update

    private void Awake()
    {
        Instance = this;
        antManager = new AntManager();
        world = new World();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        world.Update(Time.deltaTime);
    }

    public AntManager GetAntManager()
    {
        return antManager;
    }
}
