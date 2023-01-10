using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public Text PointText;
    public int Point;

    // Start is called before the first frame update
    void Start()
    {
        Point = 0;
        PointText.text = "000,000";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PointCount()
    {
        int temp = Point;
        int CountSave = 0;

        for (int i = 0; i < 5; i++)
        {
            if (temp >= 10)
            {
                temp = temp % 10;
                CountSave++;
            }
        }

        switch (6 - CountSave)
        {
            case 4:
                PointText.text = "000," + CountSave;
                break;
            case 3:
                PointText.text = "00" + CountSave/1000 + "," + CountSave%1000;
                break;
            case 2:
                PointText.text = "0" + CountSave / 1000 + "," + CountSave % 1000;
                break;
            case 1:
                PointText.text = "0" + CountSave / 1000 + "," + CountSave % 1000;
                break;
        }
    }
}
