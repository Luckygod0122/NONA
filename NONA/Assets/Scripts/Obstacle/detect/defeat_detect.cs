using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defeat_detect : MonoBehaviour
{
    public bool defeat_obs = false;
    public GameObject defeat;


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
            defeat_obs = true;
        }
    }
}
