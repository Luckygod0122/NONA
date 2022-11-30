using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_smoke_obstacle : MonoBehaviour
{

    public bool k = false; 

    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("dkdkdk");
            k = true;
        }
            
    }

    void Update()
    {

    }

}
