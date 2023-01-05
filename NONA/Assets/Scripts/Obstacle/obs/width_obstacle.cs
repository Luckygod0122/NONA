using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class width_obstacle : MonoBehaviour
{


    public bool width;
    public GameObject detect_obs;
    public float speed; // 속도값 조정


    void Start()
    {

    }


    void Update()
    {
        Speed();
        width = detect_obs.GetComponent<width_detect>().detect;

        if (transform.position.x < -13f) // 화면 밖(-9.2f)밖으로 나갈 경우 날아가는 가로 장애물 삭제
        {
            Destroy(gameObject);
        }

    }

    public void Speed()
    {
        if (width == true)
        {
            transform.Translate(transform.right * -speed * Time.deltaTime);
        }
    }

}
