using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeController : MonoBehaviour
{
    // 목숨 개수
    public Slider LifeBox;
    public int LifeItem;

    // 부품 게이지
    public Slider LifeBar;
    public int LifePoint;

    // Start is called before the first frame update
    void Start()
    {
        LifeItem = 1;
        LifePoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LifeBox.value = LifeItem;
        LifeBar.value = LifePoint;
    }

    public void LifeBarValueControll()
    {
        if (LifeItem >= 5)
        {
            // 목숨 1개 늘리기
            LifeItem++;

            // 게이지 줄이기
            LifePoint -= 5;
        }
    }

}
