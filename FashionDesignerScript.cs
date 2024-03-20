using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FashionDesignerScript : MonoBehaviour
{
    public int playerHealth;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello, I'm in the store!")
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime)
    }

    void Awake()
    {
        playerHealth = 100;
    }

    void FixedUpdate()
    {
        // Physics related code
    }
}
