using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameController.Instance.GetAntManager().RegisterCallback(OnAntCreated);
    }

    private void OnAntCreated(Ant ant)
    {
        // This method gets called when a new Ant is created by the AntManager

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
