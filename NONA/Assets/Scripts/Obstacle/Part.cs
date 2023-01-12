using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part : MonoBehaviour
{
    public GameObject PointCon;
    private AudioSource CoinSound;
    private Animator animator;

    void Start()
    {
        CoinSound = GetComponent<AudioSource>();
        animator = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("Player")) // �ε��� ���� �±װ� Player�� ��� Part ������Ʈ ����
        {
            CoinSound.Play();
            animator.SetTrigger("Part_E");
            PointCon.GetComponent<PointController>().GetPartion();
            Destroy(this.gameObject, 0.2f); // ��ǰ ���˽� 0.2�� �ڿ� ����
        }
    }

}
