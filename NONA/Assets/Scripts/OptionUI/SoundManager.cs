using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // BGM�� SE�� �����ų AudioSource ����
    public AudioSource BGMPlayer;
    public AudioSource SEPlayer;

    // ��Ȳ�� �´� AudioSource����
    // �̸����� ������ ��
    public AudioSource TestBGM;
    public AudioSource TitleBGM;

    // BGM�� ���ӿ����� ��� ������� ��ȣ �ο�
    public int BGMList;

    // Start is called before the first frame update
    void Start()
    {
        BGMPlayer.clip = TitleBGM.clip;
        BGMPlayer.Play();
        BGMList = 1;
    }

    // Update is called once per frame
    void Update()
    {
        PlayBGM();
    }

    void PlayBGM()
    {
        // ��Ȳ�� ���� BGM ��� & ���� switch��
        // BGM�� �߰��ϰ� ��ȣ�� �޾Ƽ� ��츦 ������ ��
        switch(BGMList)
        {
            // #0 �׽�Ʈ BGM
            case 0:
                TestBGM.Play();
                break;
            // #1 Ÿ��Ʋ ȭ��
            case 1:
                BGMPlayer.clip = TitleBGM.clip;
                BGMPlayer.Play();
                break;
        }
    }


}
