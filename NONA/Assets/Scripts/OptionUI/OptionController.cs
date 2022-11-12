using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    // �ɼ� ������Ʈ ��������
    public GameObject OptionWindow;
    public GameObject OptionButton;

    public AudioClip OptionButtonSE;

    // �ɼ�â Ȱ��ȭ
    public void OptionOn()
    {
        OptionWindow.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);
    }

    // �ɼ�â ��Ȱ��ȭ
    public void OptionOff()
    {
        OptionWindow.SetActive(false);
        OptionButton.SetActive(true);
        SoundManager.instance.PlaySound("OptionOff", OptionButtonSE);
    }
}
