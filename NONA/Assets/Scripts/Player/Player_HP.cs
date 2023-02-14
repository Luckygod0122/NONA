using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public GameObject worldmove;
    public Animator anim;

    public int PlayerHP = 1; // �÷��̾� ���� ü�� 1
    public int part = 0; // �÷��̾ ������ �� ���� ��ǰ�� ���� 

    public AudioSource mysfx;
    public AudioClip ReviveSound;
    public AudioClip GetLife;
    public AudioClip DieSound;

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
            if (part == 5) // ���� part�� 5����� �÷��̾� ü�� +1
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
}
