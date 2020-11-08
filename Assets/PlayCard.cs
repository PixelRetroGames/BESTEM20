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
    public void Play2(GameObject card) {
        if (card.GetComponent<Card>().played) {
            return;
        }
        GameObject play_collection = card.transform.parent.gameObject;
        GameObject player = play_collection.transform.parent.parent.gameObject;

        // play_collection.GetComponent<CardCollection>().RemoveCard(this.transform.parent.parent.gameObject);
        print("ionut e un scump cauzat naturii " + play_collection.tag);
        print(card.GetComponent<Card>().name);
        if (play_collection.transform.parent.gameObject.tag.Equals("board")) {
            // Handle board
            print("sunt pe masa saule");
            var attack_logic = GameObject.FindGameObjectWithTag("Attack").GetComponent<AttackLogic>();
            var game =  GameObject.FindGameObjectWithTag("game").GetComponent<Game>();
            // FACE ATTACK
            if (game.players[game.Other()].GetComponent<Player>().board.cards.Count == 0) {
                game.players[game.Other()].GetComponentInChildren<Health>().TakeDamage(card.GetComponent<Card>().attack);
            } else {
                var defender = game.players[game.Other()].GetComponent<Player>().board.cards[0];
                attack_logic.Attack(card.GetComponent<Card>(), defender.GetComponent<Card>());
                /*play_collection.GetComponent<CardCollection>().RemoveCard(card);
                Destroy(card);*/
            }
            card.GetComponent<Card>().played = true;
            card.transform.GetChild(0).gameObject.SetActive(false);
            card.transform.GetChild(8).transform.GetChild(0).gameObject.SetActive(false);
        } else {
            // Handle hand
            player.GetComponentInChildren<Mana>().SpendMana(card.GetComponent<Card>().mana);
            play_collection.GetComponent<CardCollection>().RemoveCard(card);
            player.GetComponent<Player>().board.AddCard(card);
        }
    }
    public void Play() {
        print("Click registered");
        GameObject card = this.transform.parent.parent.gameObject;
        Play2(card);
    } 
}
