using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionController : MonoBehaviour
{
    // 옵션 UI 오브젝트 가져오기
    public GameObject OptionWindow;
    public GameObject OptionButton;
    public GameObject OptionWindowInStage;
    public GameObject OptionSet;

    public AudioClip OptionButtonSE;
    void Update()
    {
        OptionUISwitcher();
    }

    private void OptionUISwitcher()
    {
        if(SceneManager.GetActiveScene().name == "Title")
        {
            OptionWindowInStage.SetActive(false);
            OptionWindow.SetActive(true);
        }
        else
        {
            OptionWindowInStage.SetActive(true);
            OptionWindow.SetActive(false);
        }
    }

    // 옵션창 활성화
    public void OptionOn()
    {
        OptionSet.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);
    }

    // 옵션창 비활성화
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
