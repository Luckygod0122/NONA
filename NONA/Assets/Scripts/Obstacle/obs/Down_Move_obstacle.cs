using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Move_obstacle : MonoBehaviour
{
    public float speed3; // �ӵ��� ����
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.up * speed3 * Time.deltaTime); // ���ư��� �ӵ�

        if (transform.position.y > -2.62f) // �ö� �� �ִ�ġ -2.62f���� �ö��� ���
        {
            speed3 = speed3 * -1; // speed3���� ������ �Ͽ� ���������� �ϱ�
        }
        if (transform.position.y < -4.65f) // ������ �� �ִ�ġ -4.65f���� �������� ���
        {
            speed3 = speed3 * -1; // ������ �ٲ� speed���� ������ ���� ����� �ٲپ� �ö󰡵��� ������
        }
    }
}
