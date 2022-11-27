using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionController : MonoBehaviour
{
    // �ɼ� UI ������Ʈ ��������
    public GameObject OptionButton;
    public GameObject OptionSet;

    public AudioClip OptionButtonSE;

    // �ɼ�â Ȱ��ȭ
    public void OptionOn()
    {
        OptionSet.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);
    }

    // �ɼ�â ��Ȱ��ȭ
    public void OptionOff()
    {
        OptionSet.SetActive(false);
        OptionButton.SetActive(true);
        SoundManager.instance.PlaySound("OptionOff", OptionButtonSE);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        OptionOff();
    }
}
