using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartFlash : MonoBehaviour
{
    public Animator anim;
    public AudioClip fire_Sound;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetBool("Effect", true); // 부품 사라지는 이펙트 실행
            Destroy(this.gameObject, 0.5f); // 이펙트 0.5초 뒤에 삭제
        }
    }
}
