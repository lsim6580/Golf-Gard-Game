using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameState", menuName = "States/GameState")]
public class GameState : ScriptableObject {
    public Turn Turn { get; set; }

    public GameState()
    {
        Turn = new Turn();
    }
}
