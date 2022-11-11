using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
    // 옵션 오브젝트 가져오기
    public GameObject OptionWindow;
    public GameObject OptionButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 옵션창 활성화
    public void OptionOn()
    {
        OptionWindow.SetActive(true);
        OptionButton.SetActive(false);
    }

    // 옵션창 비활성화
    public void OptionOff()
    {
        OptionWindow.SetActive(false);
        OptionButton.SetActive(true);
    }
}
