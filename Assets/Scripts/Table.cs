using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AllCards;
    public GameState GameState;
    void Start()
    {
        GameState.Turn = new Turn();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
