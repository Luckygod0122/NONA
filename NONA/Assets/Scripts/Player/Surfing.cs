using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surfing : MonoBehaviour
{
    float JumpPower =0;
    void Update()
    {
         if (Input.GetKey(KeyCode.R)) // 모바일 터치로 변경
         {
            JumpPower += 1;
            Debug.Log("파워는:" + JumpPower);
            if(JumpPower > 100)
            {
                JumpPower = 100;
            }
         }
         else if (Input.GetKeyUp(KeyCode.R))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, JumpPower / 4, 0); 
            JumpPower = 0;
        }
    }
}
