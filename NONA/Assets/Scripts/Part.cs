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
        if (collision.CompareTag("Player")) // �ε��� ���� �±װ� Player�� ��� Part ������Ʈ ����
        {
            Destroy(this.gameObject);
        }
    }
}
