using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindCondition : MonoBehaviour
{
    public Game game;
    public void Check() {
        int hp1, hp2;
        hp1 = game.players[0].GetComponentInChildren<Health>().health;
        hp2 = game.players[1].GetComponentInChildren<Health>().health;
        if (hp2 == 0) {
            foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
                 Destroy(o);
            }
            Application.LoadLevel("WinScene");
        } else if (hp1 == 0) {
            foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
                 Destroy(o);
            }
            Application.LoadLevel("OpponentWon");
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.FindGameObjectWithTag("game").GetComponent<Game>();  
        print("Game = " + game); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
