using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Screen width = " + Screen.width.ToString());
        GetComponentInChildren<CardCollection>().transform.position = new Vector3(- 1.0f * Screen.width / 200, transform.position.y, 0);
        print("Card collectio" + GetComponentInChildren<CardCollection>().transform.position.ToString());
        GetComponentInChildren<CardCollection>().w = 1.0f * Screen.width / 100;
        GetComponentInChildren<CardCollection>().GetComponent<CardCollection>().ForceStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
