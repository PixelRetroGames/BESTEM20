using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEvent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void OnMouseOver() {
        GameObject card = transform.parent.gameObject;
        if (card.transform.parent.parent.tag.Equals("hand")) 
        {
            GameObject mana_obj = card.transform.parent.parent.parent.GetComponentInChildren<Mana>().gameObject;
            if (card.GetComponent<Card>().mana <= mana_obj.GetComponent<Mana>().GetMana() && 
                transform.parent.parent.parent.parent.GetComponent<Player>().board.cards.Count <= 4) {
                transform.parent.GetComponentInChildren<PlayCard>().transform.GetChild(0).gameObject.SetActive(true);
            }
        } else {
            transform.parent.GetComponentInChildren<PlayCard>().transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    void OnMouseExit() {
       transform.parent.GetComponentInChildren<PlayCard>().transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
