using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BGMVolume : MonoBehaviour
{
    public AudioMixer Mixer;
    public Slider BGMSlider;

    // Start is called before the first frame update
    //void Start()
    //{
    //    BGMSlider.value = PlayerPrefs.GetFloat("BGMVolume", 1.0f);
    //    Mixer.SetFloat("BGMVolume", Mathf.Log10(BGMSlider.value) * 20);
    //}

    public void SetBGMVolume(float value)
    {
        Mixer.SetFloat("BGMVolume", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("BGMVolume", value);
    }
}
