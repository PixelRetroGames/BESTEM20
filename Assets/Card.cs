using UnityEngine;
using System.IO;
using System;

public class Card : MonoBehaviour
{
    public string file_path;
    public int id;
    public int mana, attack, hp;
    public string image, description;


    // Start is called before the first frame update
    void Start()
    {
        StreamReader inp_stm = new StreamReader(file_path);
        string[] var_strings = new string[]{ "name", "image", "description" };

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            string[] parts = inp_ln.Split('=');

            string var_name = parts[0];
            var_name = var_name.TrimEnd(' ');
            bool printed = false;
            for (int i = 0; i < var_strings.Length && !printed; i++)
            {
                if (var_name.Equals(var_strings[i]))
                {
                    string value = parts[1];
                    print(var_name + " := " + value);
                    printed = true;
                    if (var_name.Equals("name")) {
                        name = value;
                    } else if (var_name.Equals("image")) {
                        image = value;
                    } else if (var_name.Equals("description")) {
                        description = value;
                    }
                }
            }

            if (!printed)
            {
                int value = Int32.Parse(parts[1]);
                print(var_name + " := " + value);
                if (var_name.Equals("id")) {
                    id = value;
                } else if (var_name.Equals("mana")){
                    mana = value;
                } else if (var_name.Equals("hp")) {
                    hp = value;
                } else if (var_name.Equals("attack")) {
                    attack = value;
                }
            }
        }

        inp_stm.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
