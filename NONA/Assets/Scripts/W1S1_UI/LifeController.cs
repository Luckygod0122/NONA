using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeController : MonoBehaviour
{
    // ��� ����
    public Slider LifeBox;
    public int LifeItem;

    // ��ǰ ������
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
            // ��� 1�� �ø���
            LifeItem++;

            // ������ ���̱�
            LifePoint -= 5;
        }
    }

}
