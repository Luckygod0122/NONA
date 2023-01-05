using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);

        if (transform.position.y < -8)
        {
            Destroy(gameObject);
        }

    }



}
