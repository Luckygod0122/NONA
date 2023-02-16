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

    /*
     * ����
     * 
     * public SoundManager soundManager; // �ٿ��ֱ�
     * soundManager.PlaySound("�̸�", AudioClip ����, �Ҹ�ũ��); // ȿ���� ����� ���� �ֱ�
     * soundManager.BGMPlayer("�̸�", AudioClip ����, �Ҹ�ũ��); // ����� ����� ���� �ֱ�
     */
    public void PlaySound(string SoundName, AudioClip SoundFile, float SoundVolume)
    {
        // �Ҹ� �߻� �� ����ϴ� ������Ʈ�� ����
        GameObject SoundPlayer = new GameObject(SoundName + "Player");
        // ������ ������Ʈ�� AudioSource ������Ʈ �߰�
        AudioSource audioSource = SoundPlayer.AddComponent<AudioSource>();
        // �ͼ� �׷� ����
        audioSource.outputAudioMixerGroup = Mixer.FindMatchingGroups("SE")[0];
        // �Ҹ� ���� ����
        audioSource.clip = SoundFile;
        audioSource.volume = SoundVolume;
        // ���
        audioSource.Play();

        // ��� �� ������Ʈ �ı�
        Destroy(SoundPlayer, SoundFile.length);
    }

    // ����� ������� ������ �����ִ� �Լ�
    public void BGMPlayer(string SoundName, AudioClip audioClip, float SoundVolume)
    {
        // �Ҹ� �߻� �� ����ϴ� ������Ʈ�� ����
        GameObject SoundPlayer = new GameObject(SoundName + "Player");
        // ������ ������Ʈ�� AudioSource ������Ʈ �߰�
        AudioSource BGM = SoundPlayer.AddComponent<AudioSource>();

        // �ͼ� �׷� ����
        BGM.outputAudioMixerGroup = Mixer.FindMatchingGroups("BGM")[0];

        // Scene ��ȣ�� �´� BGM�� ���
        // �̸� ��ȣ�� Scene�� ����� �ʿ䰡 �ִ�.

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
