using UnityEngine;
using System.IO;
using System;

public class Card : MonoBehaviour
{
    public string file_path;
    public int id;
    public int mana, attack, hp;


    // Start is called before the first frame update
    void Start()
    {
        StreamReader inp_stm = new StreamReader(file_path);
        string[] var_strings = new string[]{ "name", "image", "description" };

        while (!inp_stm.EndOfStream)
        {
            string inp_ln = inp_stm.ReadLine();
            string[] parts = inp_ln.Split('=');
            print(parts[0]);
            print(parts[1]);

            string var = parts[0];
            var.TrimEnd();
            print(var);
            bool printed = false;
            for (int i = 0; i < var_strings.Length && !printed; i++)
            {
                if (var.Equals(var_strings))
                {
                    string value = parts[1];
                    print(var + " := " + value);
                    printed = true;
                }
            }

            if (!printed)
            {
                int value = Int32.Parse(parts[1]);
                print(var + " := " + value);
            }
        }

        inp_stm.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
