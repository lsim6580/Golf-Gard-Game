using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Dealer : MonoBehaviour
{
    public static List<string> SUITS = new List<string>() { "Club", "Diamond", "Heart", "Spade" };
    private List<GameObject> DrawPile = new List<GameObject>();
    private Player_Hand CurrentPlayer;
    private List<GameObject> DiscardPile;
    public GameObject Deck;
    // Start is called before the first frame update
    void Start()
    {
        //initialize the cards
        CurrentPlayer = GameObject.Find("Player_1_Hand").GetComponent<Player_Hand>();
        CurrentPlayer.IsCurrentPlayer = true;
        var parent = GameObject.Find("Blue_AllCards_00");
        foreach(Transform child in parent.transform)
        {
            if( !child.name.Contains("Joker") && !child.name.Contains("Blank"))
            {
                DrawPile.Add(child.gameObject);
            }
        }
        Shuffle();
        Deal("Player_1_Hand");
    }

    public void Deal(string playerObject)
    {
        var player = GameObject.Find(playerObject);
        var playerHand = player.GetComponent<Player_Hand>();
        while(playerHand.NeedsACard)
        {
            playerHand.PlaceCard(DrawPile.First());
            DrawPile.RemoveAt(0);
        }
    }

    public GameObject GiveCard()
    {
        var card = DrawPile.First();
        DrawPile.RemoveAt(0);
        return card;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Shuffle()
    {
        var random = new System.Random();
        var n = DrawPile.Count;
        while(n > 0)
        {
            n--;
            int k = random.Next(n + 1);
            var card = DrawPile[k];
            DrawPile[k] = DrawPile[n];
            DrawPile[n] = card;
        }
    }
}
