using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject Card;
    Dealer Dealer;
    GameState GameState;
    public void Start()
    {
        Dealer = GameObject.Find("Dealer").GetComponent<Dealer>();
    }
    public void OnMouseDown()
    {
        Debug.Log(this.gameObject.name);
        if (Card == null)
        {
            Card = Dealer.GiveCard();
            var position = gameObject.transform.position;
            position.y += .11f;
            Card.transform.position = position;
            Card.transform.Rotate(0, 90, 0);
            GameState.Turn.DrawCardSelected = Card;
            
        }
    }
}
