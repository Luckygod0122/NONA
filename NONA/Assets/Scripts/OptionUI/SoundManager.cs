using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    // 싱글턴 (오브젝트 1개만 존재하도록)
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public AudioMixer Mixer;

    // 상황에 맞는 AudioClip
    // 이름으로 구분할 것
    public AudioClip[] BGMList;

    // BGM 재생용 AudioSource
    public AudioSource BGM;

    public void PlaySound(string SoundName, AudioClip SoundFile)
    {
        // 소리 발생 시 재생하는 오브젝트를 생성
        GameObject SoundPlayer = new GameObject(SoundName + "Player");
        // 생성된 오브젝트에 AudioSource 컴포넌트 추가
        AudioSource audioSource = SoundPlayer.AddComponent<AudioSource>();
        // 믹서 그룹 설정
        audioSource.outputAudioMixerGroup = Mixer.FindMatchingGroups("SE")[0];
        // 소리 파일 설정
        audioSource.clip = SoundFile;
        audioSource.volume = 0.2f;
        // 재생
        audioSource.Play();

        // 재생 후 오브젝트 파괴
        Destroy(SoundPlayer, SoundFile.length);
    }

    // 재생할 배경음의 설정을 정해주는 함수
    public void BGMPlayer(string BGMName)
    {
        // 믹서 그룹 설정
        BGM.outputAudioMixerGroup = Mixer.FindMatchingGroups("BGM")[0];

        Debug.Log(BGMName);
        switch(BGMName)
        {
            case "Test":
                BGM.clip = BGMList[0];
                break;
            case "Test_Title":
                BGM.clip = BGMList[1];
                break;
        }

        BGM.loop = true;
        BGM.volume = 0.1f;
        BGM.Play();
    }

    public void BGMVolume(float value)
    {
        Mixer.SetFloat("BGMVolume", Mathf.Log10(value) * 20);
    }

    public void SEVolume(float value)
    {
        Mixer.SetFloat("SEVolume", Mathf.Log10(value) * 20);
    }
}
