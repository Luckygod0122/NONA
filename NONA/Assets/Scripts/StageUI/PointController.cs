using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    public Text PointText;
    public int Point;

    public GameObject LifeController;

    // Start is called before the first frame update
    void Start()
    {
        Point = 0;
        PointText.text = "000,000";
    }

    // Update is called once per frame
    void Update()
    {
        PointCount();
    }

    public void GetPartion()
    {
        LifeController.GetComponent<LifeController>().LifePoint += 1;
        Point += 100;
    }

    public void PointCount()
    {
        int temp = Point;
        int CountSave = 0;

        for (int i = 0; i < 6; i++)
        {
            if (temp >= 10)
            {
                temp /= 10;
                CountSave++;
            }
        }

        switch (CountSave)
        {
            case 2:
                PointText.text = "000," + Point.ToString();
                break;
            case 3:
                PointText.text = "00" + (Point / 1000).ToString() + "," + (Point % 1000).ToString();
                break;
            case 4:
                PointText.text = "0" + (Point / 1000).ToString() + "," + (Point % 1000).ToString();
                break;
            case 5:
                PointText.text = (Point / 1000).ToString() + "," + (Point % 1000).ToString();
                break;
        }
    }
}
