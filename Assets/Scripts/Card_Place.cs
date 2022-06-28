using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card_Place : MonoBehaviour
{
    public bool HasFlipped { get; private set; }
    public bool IsSelected { get; set; }
    public GameState GameState;
    
    public GameObject card;
    public void OnMouseDown()
    {
        if (!HasFlipped)
        {
            card.transform.Rotate(0, 0, -180);
            HasFlipped = true;
        }
        GameState.Turn.PlayerCardSelected = card;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AssignCard(string name)
    {
        card = GameObject.Find(name);
    }
}
