using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StageStartAnimation : MonoBehaviour
{
    public GameObject StageAnimator;
    public AudioClip DoorSE;

    private void Start()
    {
        SoundManager.instance.PlaySound("DoorSE", DoorSE, 1f);
    }

    public void AfterAnimationPlayed()
    {
        StageAnimator.SetActive(false);
    }
}
