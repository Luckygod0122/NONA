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

    /*
     * 사용법
     * 
     * public SoundManager soundManager; // 붙여넣기
     * soundManager.PlaySound("이름", AudioClip 변수, 소리크기); // 효과음 재생할 곳에 넣기
     * soundManager.BGMPlayer("이름", AudioClip 변수, 소리크기); // 배경음 재생할 곳에 넣기
     */
    public void PlaySound(string SoundName, AudioClip SoundFile, float SoundVolume)
    {
        // 소리 발생 시 재생하는 오브젝트를 생성
        GameObject SoundPlayer = new GameObject(SoundName + "Player");
        // 생성된 오브젝트에 AudioSource 컴포넌트 추가
        AudioSource audioSource = SoundPlayer.AddComponent<AudioSource>();
        // 믹서 그룹 설정
        audioSource.outputAudioMixerGroup = Mixer.FindMatchingGroups("SE")[0];
        // 소리 파일 설정
        audioSource.clip = SoundFile;
        audioSource.volume = SoundVolume;
        // 재생
        audioSource.Play();

        // 재생 후 오브젝트 파괴
        Destroy(SoundPlayer, SoundFile.length);
    }

    // 재생할 배경음의 설정을 정해주는 함수
    public void BGMPlayer(string SoundName, AudioClip audioClip, float SoundVolume)
    {
        // 소리 발생 시 재생하는 오브젝트를 생성
        GameObject SoundPlayer = new GameObject(SoundName + "Player");
        // 생성된 오브젝트에 AudioSource 컴포넌트 추가
        AudioSource BGM = SoundPlayer.AddComponent<AudioSource>();

        // 믹서 그룹 설정
        BGM.outputAudioMixerGroup = Mixer.FindMatchingGroups("BGM")[0];

        // Scene 번호에 맞는 BGM을 재생
        // 미리 번호와 Scene을 맞춰둘 필요가 있다.

        if(BGM.isPlaying)
        {
            BGM.Stop();
        }

        BGM.clip = audioClip;

        BGM.loop = true;
        BGM.volume = SoundVolume;
        BGM.Play();
    }

}
