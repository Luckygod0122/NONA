using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_detect : MonoBehaviour
{

    public bool Detect = false;

    void Start()
    {

    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

            Detect = true;
        }

    }

    void Update()
    {

    }

}