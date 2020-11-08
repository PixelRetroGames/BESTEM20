using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndTurn : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }

    public int OtherPlayer(int p) {
        return (p + 1) % 2;
    }

    public void Deactivate(int p) {
        var game = transform.parent.parent.gameObject.GetComponent<Game>();
        var player = game.players[p].GetComponent<Player>();
        
        Card[] cards = player.GetComponentsInChildren<Card>();
        for (int i = 0; i < cards.Length; i++) {
            cards[i].transform.GetChild(0).gameObject.SetActive(false);
        }

    }

    public void Activate(int p) {
        var game = transform.parent.parent.gameObject.GetComponent<Game>();
        var player = game.players[p].GetComponent<Player>();

        if (player.transform.tag.Equals("Opponent")) {
            return;
        }

        Card[] cards = player.GetComponentsInChildren<Card>();
        for (int i = 0; i < cards.Length; i++) {
            cards[i].transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void OnClick() {
        // for two players break glass
        var game = transform.parent.parent.gameObject.GetComponent<Game>();

        
        var player = game.players[OtherPlayer(game.player_turn)].GetComponent<Player>();
        player.GetComponentInChildren<Mana>().AddMana();
        string card_path = player.GetComponentInChildren<DeckCards>().NextCard();
        if (card_path != null) {
            if (player.hand.cards.Count <= 6) {
                player.hand.AddCard(card_path);
            } else {
                print("My hand is too full");
            }
        }

        Deactivate(game.player_turn);
        game.player_turn = OtherPlayer(game.player_turn);
        Activate(game.player_turn);
        print("mumu mare la gabi " +player.transform.tag);
        if (player.transform.tag.Equals("Opponent")) {
            player.GetComponentInChildren<AI>().PlayCards();
            
        }
    }
}
