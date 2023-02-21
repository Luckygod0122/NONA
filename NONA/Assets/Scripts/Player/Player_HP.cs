using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_HP : MonoBehaviour
{
    public GameObject worldmove;
    public Animator anim;

    public int PlayerHP = 3; // �÷��̾� ���� ü�� 1
    public int part = 0; // �÷��̾ ������ �� ���� ��ǰ�� ���� 
    public int count = 0;

    public AudioSource mysfx;
    public AudioClip ReviveSound;
    public AudioClip GetLife;
    public AudioClip DieSound;
    public AudioClip HitSound;

    public StageEnd EndScript;

    private SpriteRenderer Sprite; // �÷��̾� ü�� ������ �� ���������� �� ���� ���ؼ� �ۼ�
    private Color originColor; // ���� ����

    private void Start()
    {
        Sprite = GetComponent<SpriteRenderer>();
        originColor = Sprite.material.color;
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
                StartCoroutine(OnHitColor());
            }

            else if (count == 1)
            {
                StartCoroutine(unbeatable());
                // count = 0;
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

    // �÷��̾� ��ֹ� ���� ��, ���� ���¸� ������ ǥ��
    private IEnumerator OnHitColor()
    {
        Sprite.material.color = Color.red; // ���������� ����
        yield return new WaitForSeconds(0.1f); // �ٷ� ���� 0.1�� ���
        Sprite.material.color = originColor;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = originColor;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        Sprite.material.color = originColor;
        yield return new WaitForSeconds(0.1f);
    }

    private IEnumerator unbeatable() // 0.6�� ����
    {
        PlayerHP -= 0;
        yield return new WaitForSeconds(0.6f);
        count = 0;
    }

    private void Dead() // �÷��̾� ��� �� �μ���
    {
//        Destroy(this.gameObject, 1f);
        worldmove.gameObject.GetComponent<WorldMove>().speed = 0;
        anim.SetBool("Die",true);
       mysfx.PlayOneShot(DieSound);
    }
}
