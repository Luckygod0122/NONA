using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    // �̱��� (������Ʈ 1���� �����ϵ���)
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

    // BGM ����� AudioSource
    public AudioSource BGM;

    private void Start()
    {
        PlayerPrefs.GetFloat("BGMVolume", 1.0f);
        PlayerPrefs.GetFloat("SEVolume", 1.0f);
    }

    public void PlaySound(string SoundName, AudioClip SoundFile)
    {
        // �Ҹ� �߻� �� ����ϴ� ������Ʈ�� ����
        GameObject SoundPlayer = new GameObject(SoundName + "Player");
        // ������ ������Ʈ�� AudioSource ������Ʈ �߰�
        AudioSource audioSource = SoundPlayer.AddComponent<AudioSource>();
        // �ͼ� �׷� ����
        audioSource.outputAudioMixerGroup = Mixer.FindMatchingGroups("SE")[0];
        // �Ҹ� ���� ����
        audioSource.clip = SoundFile;
        audioSource.volume = 0.2f;
        // ���
        audioSource.Play();

        // ��� �� ������Ʈ �ı�
        Destroy(SoundPlayer, SoundFile.length);
    }

    // ����� ������� ������ �����ִ� �Լ�
    public void BGMPlayer(AudioClip audioClip)
    {
        // �ͼ� �׷� ����
        BGM.outputAudioMixerGroup = Mixer.FindMatchingGroups("BGM")[0];

        // Scene ��ȣ�� �´� BGM�� ���
        // �̸� ��ȣ�� Scene�� ����� �ʿ䰡 �ִ�.
        BGM.clip = audioClip;

        BGM.loop = true;
        BGM.volume = 0.1f;
        BGM.Play();
    }

    public void StopBGM()
    {
        BGM.Stop();
    }

}
