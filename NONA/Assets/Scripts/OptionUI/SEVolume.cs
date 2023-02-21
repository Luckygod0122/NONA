using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SEVolume : MonoBehaviour
{
    public AudioMixer Mixer;
    public Slider SESlider;

    // Start is called before the first frame update
    void Start()
    {
        SESlider.value = PlayerPrefs.GetFloat("SEVolume", 1.0f);
        Mixer.SetFloat("SEVolume", Mathf.Log10(SESlider.value) * 20);
    }

    public void SetSEVolume(float value)
    {
        Mixer.SetFloat("SEVolume", Mathf.Log10(value) * 20);
        PlayerPrefs.SetFloat("SEVolume", value);
    }
}
