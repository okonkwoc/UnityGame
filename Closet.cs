using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : MonoBehaviour
{ 
    string [] clothes;
    // Start is called before the first frame update

    void Start()
    {
        string [] clothes = ("top", "skirt", "shoes", "dress")
        for (int i = 0; i < clothes.length; i++){
            Console.WriteLine(clothes[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


