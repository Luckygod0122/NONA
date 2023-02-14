using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SurfingJumpClick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public static bool isBtnDown = false;
    public float JumpPower = 0;
    public GameObject Player;

    public GameObject UIScript;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (SurfingJumpClick.isBtnDown == true) // ��ư�� ������ �� �Լ��� �����Ӹ��� ������ �Ǿ�� �� jumpPower ��� ����
        {
            JumpPower += 4;
            if (JumpPower > 100)
            {
                JumpPower = 100;
            }
        }
        
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isBtnDown = true;
        UIScript.GetComponent<PlayerUIManager>().Surfing_Click_Down();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isBtnDown = false;
        UIScript.GetComponent<PlayerUIManager>().Surfing_Click_Up();
        if (PlayerController.surfingJumpCount == 1) //PlayerController�� �ִ� surfingJumpCont �� �׶��忡 ������ 1, ������ ����ϸ� 0�� ��
        {
            Player.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, JumpPower / 4, 0);
            PlayerController.surfingJumpCount = 0;
        }
        JumpPower = 0;
    }
}
