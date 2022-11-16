using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // 부딪힌 것의 태그가 Player일 경우 Part 오브젝트 삭제
        {
            Destroy(this.gameObject);
        }
    }
}
