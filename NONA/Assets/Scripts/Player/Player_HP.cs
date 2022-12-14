using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public int PlayerHP = 1; // �÷��̾� ���� ü�� 1
    public int part = 0; // �÷��̾ ������ �� ���� ��ǰ�� ���� 
    public int Score = 0; // ��ǰ�� �Ծ��� �� ��� ����

    void Update()
    {
        if (PlayerHP == 0) // �÷��̾� ü���� 0�� ��� ���
        {
            Dead();
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle")) // �ε��� ���� �±װ� obstacle�� ���
        {
            PlayerHP -= 1; // �÷��̾� ü�� -1
        }
        else if (collision.CompareTag("Part")) // �ε��� ���� �±װ� Part�� ���
        {
            part += 1;   // part 1���� �߰�
            Score += 10;
            if (part == 5) // ���� part�� 5����� �÷��̾� ü�� +1
            {
                part = 0;
                PlayerHP += 1;
            }
        }
    }

    private void Dead() // �÷��̾� ��� �� �μ���
    {
        Destroy(this.gameObject);
    }
}
