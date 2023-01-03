using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionController : MonoBehaviour
{
    // 옵션 UI 오브젝트 가져오기
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

    // 옵션창 활성화
    public void OptionOn()
    {
        OptionSet.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);

        ifPaused = true;
    }

    // 옵션창 비활성화
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
