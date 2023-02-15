using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    // 옵션 UI 오브젝트 가져오기
    public GameObject OptionButton;
    public GameObject OptionSet;

    public AudioClip OptionButtonSE;

    public bool ifPaused;

    public Text PauseCountdown;

    private void Start()
    {
        ifPaused = false;
    }

    // 옵션창 활성화
    public void OptionOn()
    {
        OptionSet.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE);

        Time.timeScale = 0;
    }

    // 옵션창 비활성화
    public void OptionOff()
    {
        OptionSet.SetActive(false);
        OptionButton.SetActive(true);
        SoundManager.instance.PlaySound("OptionOff", OptionButtonSE);

        StartCoroutine(CountinueCountdown());
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

    private IEnumerator CountinueCountdown()
    {
        Time.timeScale = 0.001f;

        for (int number = 3; number > 0; number--)
        {
            ChangeText(number.ToString());
            yield return new WaitForSeconds(1*0.001f);
        }

        string empty = "";
        ChangeText(empty);

        Time.timeScale = 1f;
    }

    private void ChangeText(string number)
    {
        PauseCountdown.text = number;
    }
}
