using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Mana : MonoBehaviour
{
    private int mana, current_mana_max;
    public int mana_max;
    // Start is called before the first frame update
    void Start()
    {
        mana = 5;
        UpdateMana();
    }

    public void AddMana() {
        current_mana_max++;
        current_mana_max = Mathf.Min(current_mana_max, mana_max);
        mana = current_mana_max;
        UpdateMana();
    }

    public void SpendMana(int spent_mana) {
        mana -= spent_mana;
        UpdateMana();
    }

    public void UpdateMana() {
        this.transform.GetChild(1).GetComponent<Text>().text = mana.ToString();
    }

    public int GetMana() {
        return mana;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
