using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartCount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("자식 개수: " + this.transform.childCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
