using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    public int player_turn;
    public GameObject[] players;

    public int Other() {
        return (player_turn + 1) % 2;
    }

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
