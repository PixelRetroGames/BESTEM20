using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int starting_health;
    public int health;

    public void TakeDamage(int damage) {
        health = Mathf.Max(0, health - damage);
        UpdateString();
        transform.parent.parent.GetComponentInChildren<WindCondition>().Check();
    }
    void UpdateString() {
        this.transform.GetChild(0).GetComponent<Text>().text = "Hp: " + health.ToString();
    }
    void Start()
    {
        health = starting_health;
        UpdateString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
