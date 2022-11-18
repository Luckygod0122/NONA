using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TitleTouch : MonoBehaviour, IPointerClickHandler
{
    SoundManager soundManager;

    void Start()
    {
        soundManager.BGMPlayer(0);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene("StageSelect");
    }
}

