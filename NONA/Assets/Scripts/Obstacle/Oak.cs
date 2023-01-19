using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oak : MonoBehaviour
{
    Animator anim;
    GameObject Player;

    void Start()
    {
        anim = GetComponent<Animator>();
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.GetComponent<PlayerController>().dashSkill == true && collision.gameObject.CompareTag("Player"))
        {
            anim.SetTrigger("destroy");
            Destroy(this, 0.3f);
        }
    }

}
