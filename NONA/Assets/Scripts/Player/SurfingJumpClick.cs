using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SurfingJumpClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool isBtnDown = false;
    public float JumpPower = 0;
    public GameObject Player; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (SurfingJumpClick.isBtnDown == true) // 버튼을 눌렀을 때 함수가 프레임마다 실행이 되어야 함 jumpPower 계속 증가
        {
            JumpPower += 1;
            if (JumpPower > 100)
            {
                JumpPower = 100;
            }
        }
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
        if (PlayerController.surfingJumpCount == 1) //PlayerController에 있는 surfingJumpCont 가 그라운드에 닿으면 1, 점프를 사용하면 0이 됨
        {
            Player.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, JumpPower / 4, 0);
            PlayerController.surfingJumpCount = 0;
        }
        JumpPower = 0;
    }
}
