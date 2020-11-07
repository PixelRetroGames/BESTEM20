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

    public void OnClick() {
        // for two players break glass
        transform.parent.parent.GetComponentInChildren<Player>().GetComponentInChildren<Mana>().AddMana();
    }
}
