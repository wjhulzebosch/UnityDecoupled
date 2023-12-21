using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntViewer : MonoBehaviour
{
    public Ant ant;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RegisterAnt(Ant ant)
    {

    }

    internal void RegisterWithAnt(Ant ant)
    {
        this.ant = ant;
        ant.RegisterCallback(OnAntUpdated);
    }

    private void OnAntUpdated(Ant ant)
    {
        // Update the position of the ant
        transform.position = ant.position;
    }
}
