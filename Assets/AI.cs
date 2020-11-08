using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;

    public void PlayCards() {
        print("salut sunt in ai shaule");
        print(player.transform.tag + " dedes");
        var cards = player.hand.GetComponent<CardCollection>().cards;
        for (int i = 0; i < cards.Count; i++) {
            print(player.GetComponentInChildren<Mana>());
            if (player.GetComponentInChildren<Mana>().mana >= cards[i].GetComponent<Card>().mana && 
                player.board.cards.Count <= 4) {
                print(cards[i].name);
                cards[i].GetComponentInChildren<PlayCard>().Play2(cards[i]);
            }
        }

        cards = player.board.GetComponent<CardCollection>().cards;
        for (int i = cards.Count - 1; i >= 0; i--) {
            cards[i].GetComponentInChildren<PlayCard>().Play2(cards[i]);
        }
        transform.parent.parent.GetComponentInChildren<EndTurn>().OnClick();
    }
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
}
