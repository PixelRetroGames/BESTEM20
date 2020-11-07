using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    public List<GameObject> cards; 
    // Start is called before the first frame update
    /*void Start()
    {
        int x = -7;
        int y = 2;
        int i = 0;
        StreamReader inp_stm = new StreamReader(file_path);
        while (!inp_stm.EndOfStream && i < 5)
        {
            string inp_ln = inp_stm.ReadLine();
            GameObject card_object = Instantiate(card_prefab, new Vector2(x, y), Quaternion.identity);
            card_object.transform.parent = this.transform;
            card_object.GetComponent<Card>().Load(inp_ln);
            x += 2;
            if (x >= 3) {
                y -= 4;
                x = -7;
            }
            i++;
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
}
