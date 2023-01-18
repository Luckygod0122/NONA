using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width_obstacle : MonoBehaviour
{


    public bool width;
    public GameObject detect_obs;
    public float speed; // 속도값 조정


    void Start()
    {

    }


    void Update()
    {
        Speed();
        width = detect_obs.GetComponent<width_detect>().detect;

    }

    public void Speed()
    {
        if (width == true)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }
    }

}
