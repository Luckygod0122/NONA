using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float hAxis;
    float vAxis;
    bool wDown; // walkDown
    Vector3 moveVec;
    Animator animator;

    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");
        wDown = Input.GetButton("Walk");

        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        if (wDown)
        {
            transform.position += moveVec * speed * 0.3f * Time.deltaTime;
        }
        else
        {
            transform.position += moveVec * speed * Time.deltaTime;
        }
        animator.SetBool("isRun", moveVec != Vector3.zero);
        animator.SetBool("isWalk", wDown);

        transform.LookAt(transform.position + moveVec);
    }
}
