using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play() {
        print("Click registered");
        this.transform.parent.parent.parent.GetComponent<CardCollection>().RemoveCard(this.transform.parent.parent.gameObject);
    } 
}
