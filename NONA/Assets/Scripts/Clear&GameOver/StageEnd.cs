using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageEnd : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 스테이지의 Start 함수에 넣을 거
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
}
