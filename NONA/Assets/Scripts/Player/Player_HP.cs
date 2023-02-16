using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public GameObject worldmove;
    public Animator anim;

    public int PlayerHP = 1; // �÷��̾� ���� ü�� 1
    public int part = 0; // �÷��̾ ������ �� ���� ��ǰ�� ���� 
    public int count = 0;

    public AudioSource mysfx;
    public AudioClip ReviveSound;
    public AudioClip GetLife;
    public AudioClip DieSound;
    public AudioClip HitSound;

    public StageEnd EndScript;

    private void Start()
    {

    }
    void Update()
    {
        if (PlayerHP == 0) // �÷��̾� ü���� 0�� ��� ���
        {
            Dead();
            EndScript.ShowResult(4);
        }
        if (PlayerHP > 5)
        {
            PlayerHP = 5;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle")) // �ε��� ���� �±װ� obstacle�� ���
        {
            if (count == 0)
            {
                PlayerHP -= 1; // �÷��̾� ü�� -1
                count = 1;
                mysfx.PlayOneShot(HitSound);

            }
            
            else if (count == 1)
            {
                PlayerHP -= 0; // ���� ����
                Invoke("inv", 3);
                
            }
            
        }
        else if (collision.CompareTag("Part")) // �ε��� ���� �±װ� Part�� ���
        {
            part += 1;   // part 1���� �߰�
            if (part % 100 == 0) // ���� part�� 5����� �÷��̾� ü�� +1
            {
                PlayerHP += 1;
                mysfx.PlayOneShot(GetLife);
            }
        }
    }

    private void Dead() // �÷��̾� ��� �� �μ���
    {
//        Destroy(this.gameObject, 1f);
        worldmove.gameObject.GetComponent<WorldMove>().speed = 0;
        anim.SetBool("Die",true);
       mysfx.PlayOneShot(DieSound);
    }

    private void inv() //���� ���� �Լ�
    {
        count = 0;
    }

}
