using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top_smoke_obstacle : MonoBehaviour
{

    public float speed; // �ӵ��� ����

    void Start()
    {

    }

  

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime); // ���ư��� �ӵ�

        if (transform.position.y < 2.7f) // ȭ�� ��(-2.49f)������ ���� ��� ���ư��� ���� ��ֹ� ����
        {
            speed = 0;
        }
    }
}
