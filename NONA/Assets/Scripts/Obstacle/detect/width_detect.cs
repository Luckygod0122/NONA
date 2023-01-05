using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width_detect : MonoBehaviour
{
    public bool detect = false;
    public GameObject Obs;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            detect = true;
        }
    }
}
