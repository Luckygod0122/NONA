using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StageEnd : MonoBehaviour
{
    public int ResultNumber;

    public GameObject Result;
    public Animator ResultAnimator;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("CurrentStage", SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        ShowResult();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentStage"));
    }

    public void StageExitButton()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ShowResult()
    {
        switch(ResultNumber)
        {
            case 0:
                break;
            case 1:
                Result.SetActive(true);
                ResultAnimator.SetInteger("ResultCase", 1);
                break;
            case 2:
                Result.SetActive(true);
                ResultAnimator.SetInteger("ResultCase", 2);
                break;
            case 3:
                Result.SetActive(true);
                ResultAnimator.SetInteger("ResultCase", 3);
                break;
            case 4:
                Result.SetActive(true);
                ResultAnimator.SetBool("IfFail", true);
                break;
        }
    }
}
