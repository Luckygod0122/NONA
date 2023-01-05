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
            anim.SetBool("Effect", true); // ��ǰ ������� ����Ʈ ����
            Destroy(this.gameObject, 0.5f); // ����Ʈ 0.5�� �ڿ� ����
        }
    }
}
