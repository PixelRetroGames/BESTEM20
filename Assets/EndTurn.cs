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

    private void Deactivate(int p) {
        var game = transform.parent.parent.gameObject.GetComponent<Game>();
        var player = game.players[p].GetComponent<Player>();
        
        Card[] cards = player.GetComponentsInChildren<Card>();
        for (int i = 0; i < cards.Length; i++) {
            cards[i].transform.GetChild(0).gameObject.SetActive(false);
        }

    }

    private void Activate(int p) {
        var game = transform.parent.parent.gameObject.GetComponent<Game>();
        var player = game.players[p].GetComponent<Player>();

        Card[] cards = player.GetComponentsInChildren<Card>();
        for (int i = 0; i < cards.Length; i++) {
            cards[i].transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void OnClick() {
        // for two players break glass
        var game = transform.parent.parent.gameObject.GetComponent<Game>();

        
        var player = game.players[game.player_turn].GetComponent<Player>();
        player.GetComponentInChildren<Mana>().AddMana();
        string card_path = player.GetComponentInChildren<DeckCards>().NextCard();
        if (card_path != null) {
            player.hand.AddCard(card_path);
        }

        Deactivate(game.player_turn);
        game.player_turn = (1 + game.player_turn) % 2;
        Activate(game.player_turn);

    }
}
