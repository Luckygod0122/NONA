using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect_meteor : MonoBehaviour
{
    public bool meteor = false;
    public GameObject meteor_obs;

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
            meteor = true;
        }
    }
}
