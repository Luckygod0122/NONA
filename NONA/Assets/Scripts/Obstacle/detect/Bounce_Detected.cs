using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce_Detected : MonoBehaviour
{
    public GameObject B_obs;  // Ƣ����� ��ֹ�
    public bool deTect = false; // �����Ͽ��� �� �۵��ϵ��� ó���� false�� ����
    
    void Start()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // ���� �±װ� Player���
        {
            deTect = true; // deTect�� True�� ��ȯ�Ͽ� Bounce_obstacle�� �����ϵ��� �ϱ�
            
        }
    }
    void Update()
    {
        if (B_obs.transform.position.y > -1.17)  // ���� Ƣ����� ��ֹ��� ���� ���̸� Ƣ��ö��� ���
        {
            deTect = false; // deTect�� false�� ��ȯ
        }
    }
}
