using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    // 옵션 오브젝트 가져오기
    public GameObject OptionWindow;
    public GameObject OptionButton;

    public AudioClip OptionButtonSE;

    // 옵션창 활성화
    public void OptionOn()
    {
        OptionWindow.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);
    }

    // 옵션창 비활성화
    public void OptionOff()
    {
        OptionWindow.SetActive(false);
        OptionButton.SetActive(true);
        SoundManager.instance.PlaySound("OptionOff", OptionButtonSE);
    }
}
