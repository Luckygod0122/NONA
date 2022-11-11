using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // BGM과 SE를 재생시킬 AudioSource 변수
    public AudioSource BGMPlayer;
    public AudioSource SEPlayer;

    // 상황에 맞는 AudioSource변수
    // 이름으로 구분할 것
    public AudioSource TestBGM;
    public AudioSource TitleBGM;

    // BGM을 게임에서의 사용 순서대로 번호 부여
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
        // 상황에 따른 BGM 재생 & 변경 switch문
        // BGM을 추가하고 번호를 달아서 경우를 구분할 것
        switch(BGMList)
        {
            // #0 테스트 BGM
            case 0:
                TestBGM.Play();
                break;
            // #1 타이틀 화면
            case 1:
                BGMPlayer.clip = TitleBGM.clip;
                BGMPlayer.Play();
                break;
        }
    }


}
