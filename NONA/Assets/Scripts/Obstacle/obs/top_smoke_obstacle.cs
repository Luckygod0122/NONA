using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_smoke_obstacle : MonoBehaviour
{
    public GameObject  obstacle;
    public float speed;
    public bool down_obs;

    void Start()
    {
       


    }

    
    void Update()
    {
        Speed();
        down_obs = obstacle.GetComponent<Top_detect>().Detect;
    }

    public void Speed()
    {
        if (down_obs == true)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); // ���ư��� �ӵ�
            if (transform.position.y < 2.24222f) // ȭ�� ��(-2.49f)������ ���� ��� ���ư��� ���� ��ֹ� ����
            {
                speed = 0;
            }
        }


        
    }
}
