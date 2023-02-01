using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class StageStartAnimation : MonoBehaviour
{
    public GameObject StageAnimator;

    public void AfterAnimationPlayed()
    {
        StageAnimator.SetActive(false);
    }
}
