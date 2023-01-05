using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall_footb : MonoBehaviour
{
    void Start()
    {
        Invoke("fall", 4f);
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            fall();
        }
    }

    void fall()
    {
        Debug.Log("ssssss");
        GetComponent<Rigidbody2D>().gravityScale = 5;
    }
}
