using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop_obs : MonoBehaviour
{
    public GameObject detect;
    public bool drop;


    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    
    void Update()
    {
        drop = detect.GetComponent<drop_detect>().detect_obs;

        if (transform.position.y < -6.3)
        {
            Destroy(gameObject);
        }

    }

}
