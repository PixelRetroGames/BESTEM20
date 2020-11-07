using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() {
        print("Click registered");
        GameObject play_collection = this.transform.parent.parent.parent.gameObject;
        GameObject player = play_collection.transform.parent.parent.gameObject;
        GameObject card = this.transform.parent.parent.gameObject;

        // play_collection.GetComponent<CardCollection>().RemoveCard(this.transform.parent.parent.gameObject);
        print("ionut e un scump cauzat naturii " + play_collection.tag);
        if (play_collection.transform.parent.gameObject.tag.Equals("board")) {
            // Handle board
            print("sunt pe masa saule");
            play_collection.GetComponent<CardCollection>().RemoveCard(card);
            Destroy(card);
        } else {
            // Handle hand
            player.GetComponentInChildren<Mana>().SpendMana(card.GetComponent<Card>().mana);
            play_collection.GetComponent<CardCollection>().RemoveCard(card);
            player.GetComponent<Player>().board.AddCard(card);
        }
    } 
}
