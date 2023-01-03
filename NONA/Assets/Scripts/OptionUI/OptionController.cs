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

    public bool ifPaused;

    private void Start()
    {
        ifPaused = false;
    }

    private void Update()
    {
        if(ifPaused == true)
        {
            Time.timeScale = 0;
        }
        if (ifPaused == false)
        {
            Time.timeScale = 1;
        }
    }

    // �ɼ�â Ȱ��ȭ
    public void OptionOn()
    {
        OptionSet.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);

        ifPaused = true;
    }

    // �ɼ�â ��Ȱ��ȭ
    public void OptionOff()
    {
        OptionSet.SetActive(false);
        OptionButton.SetActive(true);
        SoundManager.instance.PlaySound("OptionOff", OptionButtonSE);

        ifPaused = false;
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        OptionOff();
    }

    public void StageExitButton()
    {
        OptionOff();
        SceneManager.LoadScene("StageSelect");
    }
}
