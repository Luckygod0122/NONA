using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top_target : MonoBehaviour
{
    public GameObject  obstacle;
    public float speed;
    bool obs;

    void Start()
    {
       obs = obstacle.GetComponent<top_smoke_obstacle>().k;


    }

    
    void Update()
    {
        Speed();
    }
    public void Speed()
    {
        if (obs == true)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime); // ���ư��� �ӵ�
        }


        else if (transform.position.y < 2.7f) // ȭ�� ��(-2.49f)������ ���� ��� ���ư��� ���� ��ֹ� ����
        {
            speed = 0;
        }
    }
}
