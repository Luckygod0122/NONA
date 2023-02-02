using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class StageEnd : MonoBehaviour
{
    public int ResultCase;

    public Animator ResultAnimator;

    // Start is called before the first frame update
    void Start()
    {
        ResultAnimator = GetComponent<Animator>();
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

    public void ShowResult()
    {
        switch(ResultCase)
        {
            case 0:
                break;
            case 1:
                ResultAnimator.SetInteger("ResultCase", 1);
                break;
            case 2:
                ResultAnimator.SetInteger("ResultCase", 2);
                break;
            case 3:
                ResultAnimator.SetInteger("ResultCase", 3);
                break;
            case 4:
                ResultAnimator.SetBool("IfFail", true);
                break;
        }
    }
}
