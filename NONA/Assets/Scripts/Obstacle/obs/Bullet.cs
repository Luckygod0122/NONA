using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed;
    private Vector3 moveDirection;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); ;

        if (transform.position.y < -8)
        {
            Destroy(gameObject);
        }

    }



}
