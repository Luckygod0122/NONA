using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Down_Move_obstacle : MonoBehaviour
{
    public float speed3; // 속도값 조정
    void Start()
    {

    }


    void Update()
    {
        transform.Translate(Vector2.up * speed3 * Time.deltaTime); // 날아가는 속도

        if (transform.position.y > -2.62f) // 올라갈 때 최대치 -2.62f까지 올라갔을 경우
        {
            speed3 = speed3 * -1; // speed3값을 음수로 하여 내려가도록 하기
        }
        if (transform.position.y < -4.65f) // 내려갈 때 최대치 -4.65f까지 내려갔을 경우
        {
            speed3 = speed3 * -1; // 음수로 바뀐 speed값을 음수를 곱해 양수로 바꾸어 올라가도록 설정함
        }
    }
}
