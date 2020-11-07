using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CreateCards : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject card_prefab;
    public string[] all_cards;

    public string file_path;
    private int n = 2;
    void Start() {
        int x = -7;
        int y = 2;
        int i = 0;
        StreamReader inp_stm = new StreamReader(file_path);
        while (!inp_stm.EndOfStream) {

            string inp_ln = inp_stm.ReadLine();
            GameObject card_object = Instantiate(card_prefab, new Vector2(x, y), Quaternion.identity);
            card_object.transform.parent = this.transform;
            card_object.GetComponent<Card>().Load(inp_ln);
            x += 2;
            if (x >= 3) {
                y -= 4;
                x = -7;
            }
        }

    }

    // Update is called once per frame
    void Update() {
        
    }
}
