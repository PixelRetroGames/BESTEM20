using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CardCollection : MonoBehaviour
{
    public GameObject card_prefab;
    public List<GameObject> cards;
    public string file_path;
    private float x, y;
    public float w, h, buf;
    // Start is called before the first frame update
    public void ForceStart()
    {
        x = transform.position.x;
        y = transform.position.y;
         
        RearrangeCards();
    }

    public void Load() {
        int i = 0;
        StreamReader inp_stm = new StreamReader(file_path);
        
        while (!inp_stm.EndOfStream && i < 5)
        {
            string inp_ln = inp_stm.ReadLine();
            GameObject card_object = Instantiate(card_prefab, new Vector2(0, 0), Quaternion.identity);
            card_object.transform.SetParent(this.transform);
            card_object.GetComponent<Card>().Load(inp_ln);
            card_object.GetComponent<Card>().file_path = inp_ln;
            cards.Add(card_object);
            i++;
        }

        RearrangeCards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCard(GameObject card) {
        print("sunt in adauga carte bucuresteanule");
        print(card.transform.parent.parent.gameObject.tag);
        GameObject card_object = Instantiate(card_prefab, new Vector2(0, 0), Quaternion.identity);
        card_object.transform.SetParent(this.transform);
        card_object.GetComponent<Card>().Load(card.GetComponent<Card>().file_path);
        cards.Add(card_object);
        RearrangeCards();
    }
    public void RemoveCard(GameObject card) {
        cards.Remove(card);
        Destroy(card);
        RearrangeCards();
    }
    public void RearrangeCards() 
    {
        print("Rearrange cards");
        print("x = " + x.ToString());
        print("y = " + y.ToString());
        if (cards.Count == 0) {
            return;
        }
        float X = x + (w - cards.Count * (cards[0].transform.localScale.x + buf)) / 2;
        float Y = y + (h - cards[0].transform.localScale.y) / 2;
        for (int i = 0; i < cards.Count; i++) {
            cards[i].transform.position = new Vector3(X + (cards[0].transform.localScale.x + buf) * (1.0f * i + 0.5f), Y, 0);
        }
    }
}
