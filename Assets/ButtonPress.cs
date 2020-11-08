using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    // Start is called before the first frame update
    public Button btn;
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    public void onClick() {
        print("poc");
         SceneManager.LoadScene("SampleScene");
    }
}
