using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteor_obs : MonoBehaviour
{
    public GameObject diag_detect;
    public bool detect = false;
    public float width_speed;
    public float down_speed;


    void Start()
    {
        
    }

    
    void Update()
    {
        Speed();
        detect = diag_detect.GetComponent<detect_meteor>().meteor;
    }

    public void Speed()
    {
        if (detect == true)
        {
            transform.Translate(transform.right * -width_speed * Time.deltaTime);
            transform.Translate(transform.up * -down_speed * Time.deltaTime);
        }
    }

}
