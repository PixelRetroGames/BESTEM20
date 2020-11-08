using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackLogic : MonoBehaviour
{
    public void Attack(Card attacker, Card defender) {
        defender.hp = Mathf.Max(0, defender.hp - attacker.attack);
        attacker.hp = Mathf.Max(0, attacker.hp - defender.attack);
        if (defender.hp <= 0) {
            defender.transform.parent.GetComponent<CardCollection>().RemoveCard(defender.gameObject);
        } else {
            defender.UpdateText();
        }
        if (attacker.hp <= 0) {
            attacker.transform.parent.GetComponent<CardCollection>().RemoveCard(attacker.gameObject);
        } else {
            attacker.UpdateText();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
