using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_Move_obstacle : MonoBehaviour
{
    public float speed3; // �ӵ��� ����
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.up * speed3 * Time.deltaTime); // ���ư��� �ӵ�

        if (transform.position.y > 4.71f) // �ö� �� �ִ�ġ 4.71f���� �ö��� ���
        {
            speed3 = speed3 * -1; // speed3���� ������ ���Ͽ� ���������� ����
        }
        if (transform.position.y < 2.56f) // ������ �� �ִ�ġ 2.56f���� �������� ���
        {
            speed3 = speed3 * -1; // speed3���� �ٽ� ������ ���Ͽ� �ö󰡵��� ����
        }

    }
}
