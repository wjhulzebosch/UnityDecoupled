using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    public GameObject antPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // This spriteController has to be informed about new objects in the world. Register with the AntManager
        // so we can be informed when a new ant is created.
        Game.Instance.AntManager.RegisterCallback(OnAntCreated);
    }

    private void OnAntCreated(Ant ant)
    {
        // This method gets called when a new Ant is created by the AntManager
        // Instantiate the Ant-prefab
        GameObject antGO = Instantiate(antPrefab, ant.position, Quaternion.identity);

        // Set the AntViewer's ant to the newly created ant
        AntViewer antViewer = antGO.GetComponent<AntViewer>();

        // Make sure the antViewer is informed when the ant is updated
        antViewer.RegisterWithAnt(ant);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
