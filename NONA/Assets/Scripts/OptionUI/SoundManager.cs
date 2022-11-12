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

    // ��Ȳ�� �´� AudioClip
    // �̸����� ������ ��
    public AudioClip[] BGMList;

    // BGM ����� AudioSource
    public AudioSource BGM;

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
    public void BGMPlayer(string BGMName)
    {
        // �ͼ� �׷� ����
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
