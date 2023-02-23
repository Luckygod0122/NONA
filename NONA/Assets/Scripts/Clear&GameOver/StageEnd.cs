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



    public void RestartButton()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentStage"));
    }

    public void StageExitButton()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void ShowResult(int ResultNumber)
    {
        switch(ResultNumber)
        {
            case 0:
                break;
            case 1:
                Result.SetActive(true);
                ResultAnimator.SetInteger("ResultCase", 1);
                DataManager.Instance.StageUnlock(SceneManager.GetActiveScene().name);
                DataManager.Instance.StageScore(SceneManager.GetActiveScene().name, 1);
                break;
            case 2:
                Result.SetActive(true);
                ResultAnimator.SetInteger("ResultCase", 2);
                DataManager.Instance.StageUnlock(SceneManager.GetActiveScene().name);
                DataManager.Instance.StageScore(SceneManager.GetActiveScene().name, 2);
                break;
            case 3:
                Result.SetActive(true);
                ResultAnimator.SetInteger("ResultCase", 3);
                DataManager.Instance.StageUnlock(SceneManager.GetActiveScene().name);
                DataManager.Instance.StageScore(SceneManager.GetActiveScene().name, 3);
                break;
            case 4:
                Result.SetActive(true);
                ResultAnimator.SetBool("IfFail", true);
                break;
        }
    }
}
