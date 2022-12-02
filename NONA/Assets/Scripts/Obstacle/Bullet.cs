using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    

    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.y < -13)
        {
            Destroy(gameObject);
        }

    }



}
