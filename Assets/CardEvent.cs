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
        transform.parent.GetComponentInChildren<PlayCard>().transform.GetChild(0).gameObject.SetActive(true);
    }

    void OnMouseExit() {
       transform.parent.GetComponentInChildren<PlayCard>().transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
