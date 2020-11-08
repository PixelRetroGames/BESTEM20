using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public CardCollection hand;
    public CardCollection board;
    private DeckCards deck;

    public float board_hand_buf;
    public int number_of_starting_cards;
    void Start()
    {
        deck = GetComponentInChildren<DeckCards>();
        print("Screen width = " + Screen.width.ToString());
        hand = GetComponentsInChildren<CardCollection>()[0];
        board = GetComponentsInChildren<CardCollection>()[1];

        print("PAAAAAAAAAREZZA" + hand.transform.parent.gameObject.tag);
        print("asjkdfasd 319" + board.transform.parent.gameObject.tag);


        hand.transform.position = new Vector3(- 1.0f * Screen.width / 200, transform.position.y, 0);
        print("Card collectio" + GetComponentInChildren<CardCollection>().transform.position.ToString());
        hand.w = 1.0f * Screen.width / 100;
        hand.ForceStart();
        for (int i = 0; i < number_of_starting_cards; i++) {
            hand.AddCard(deck.NextCard());
        }

        board.transform.position = new Vector3(hand.transform.position.x, hand.transform.position.y + board_hand_buf, 0);
        board.w = hand.w;
        board.ForceStart();

        var game = GameObject.FindGameObjectWithTag("game").GetComponent<Game>();
        transform.parent.GetComponentInChildren<EndTurn>().Activate(game.player_turn);
        transform.parent.GetComponentInChildren<EndTurn>().Deactivate((game.player_turn + 1) % 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
