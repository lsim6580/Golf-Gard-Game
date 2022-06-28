using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Player_Hand PlayerHand { get; set; }

    public void Init(string playerHandName)
    {
        PlayerHand = GameObject.Find(playerHandName).GetComponent<Player_Hand>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
