using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diagonal_obstacle : MonoBehaviour
{
    public float speed2 = 0.0025f;
    Vector3 target;
    Vector3 os; // Àå¾Ö¹°
    Vector3 newos; 
    
    void Start()
    {
        target = GameObject.Find("Player").transform.position;
        os = transform.position;

        newos = (target - os) * speed2;
        
    }

    
    void Update()
    {
        transform.position = transform.position + newos;
        if (transform.position.x < -7)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }



}
