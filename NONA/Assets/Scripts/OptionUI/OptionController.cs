using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    // �ɼ� UI ������Ʈ ��������
    public GameObject OptionButton;
    public GameObject OptionSet;

    public AudioClip OptionButtonSE;

    public bool ifPaused;

    public Text PauseCountdown;

    private void Start()
    {
        ifPaused = false;
    }

    // �ɼ�â Ȱ��ȭ
    public void OptionOn()
    {
        OptionSet.SetActive(true);
        OptionButton.SetActive(false);
        SoundManager.instance.PlaySound("OptionOn", OptionButtonSE, 0.2f);

        Time.timeScale = 0;
    }

    // �ɼ�â ��Ȱ��ȭ
    public void OptionOff()
    {
        OptionSet.SetActive(false);
        OptionButton.SetActive(true);
        SoundManager.instance.PlaySound("OptionOff", OptionButtonSE, 0.2f);

        if (OptionSet.name == "StagePause")
        {
            StartCoroutine(CountinueCountdown());
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void RestartButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StageExitButton()
    {
        Time.timeScale = 1f;
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
