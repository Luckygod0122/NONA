using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_detect : MonoBehaviour
{
    public GameObject D_obs;
    public bool detect_obs = false;

    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            D_obs.GetComponent<Rigidbody2D>().gravityScale = 1;
            detect_obs = true;
        }
    }

    void Update()
    {
       
    }
}
