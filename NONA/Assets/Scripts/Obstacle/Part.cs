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
        if (collision.CompareTag("Player")) // 부딪힌 것의 태그가 Player일 경우 Part 오브젝트 삭제
        {
            CoinSound.Play();
            animator.SetTrigger("Part_E");
            PointCon.GetComponent<PointController>().GetPartion();
            Destroy(this.gameObject, 0.2f); // 부품 접촉시 0.2초 뒤에 삭제
        }
    }

}
