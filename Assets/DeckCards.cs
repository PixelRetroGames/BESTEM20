using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Random;
using System.IO;

public class DeckCards : MonoBehaviour
{
    public GameObject card_prefab;
    public List<string> all_cards;
    public string file_path;

    private System.Random rng;  
    private void Shuffle(List<string> list)  
    {  
        int n = list.Count;  
        while (n > 1) {  
            n--;  
            int k = rng.Next(n + 1);  
            string value = list[k];  
            list[k] = list[n];  
            list[n] = value;  
        }  
    }

    // Start is called before the first frame update
    void Start()
    {
        rng = new System.Random();
        StreamReader inp_stm = new StreamReader(file_path);
        while (!inp_stm.EndOfStream) {
            string inp_ln = inp_stm.ReadLine();
            all_cards.Add(inp_ln);
        }
        Shuffle();
    }

    void Shuffle() {
        Shuffle(all_cards);
    }

    // Get next card string and remove it from list
    public string NextCard() {
        if (all_cards.Count == 0) {
            print("Lose: no more cards!");
            return null;
        }
        string card =  all_cards[0];
        all_cards.Remove(card);

        GetComponentInChildren<Text>().text = all_cards.Count.ToString();

        return card;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
