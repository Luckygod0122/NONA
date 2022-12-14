using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageEnd : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // ���������� Start �Լ��� ���� ��
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
