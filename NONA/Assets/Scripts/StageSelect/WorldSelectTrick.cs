using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldSelectTrick : MonoBehaviour
{
    public Image EmptyChart;
    public Image EmptyPaper;

    public Image W1S1;
    public Image W1S2;

    public Image W2S1;
    public Image W2S2;

    public Image W3S1;
    public Image W3S2;

    public GameObject Board;
    public GameObject Paper;
    public GameObject Buttons;
    public GameObject LightEffect;

    private float TimeCount;

    // Start is called before the first frame update
    void Start()
    {
        TimeCount = 0f;
        EmptyChart.sprite = EmptyPaper.sprite;
        SceneStart();
    }

    void Update()
    {
        TimeCount += Time.deltaTime;
        if (TimeCount <= 1f)
        {
            Board.transform.position += Vector3.MoveTowards(Vector3.zero, new Vector3(0, 1080, 0), 1080f * Time.deltaTime);
            Paper.transform.position += Vector3.MoveTowards(Vector3.zero, new Vector3(0, 1080, 0), 1080f * Time.deltaTime);
            Buttons.transform.position += Vector3.MoveTowards(Vector3.zero, new Vector3(0, 1080, 0), 1080f * Time.deltaTime);
        }
        else
        {
            LightEffect.SetActive(true);
        }

    }

    public void SceneStart()
    {
        Board.transform.localPosition = new Vector3(0, -1080, 0);
        Paper.transform.localPosition = new Vector3(0, -1080, 0);
        Buttons.transform.localPosition = new Vector3(0, -1080, 0);
    }


    public void EmptyChartTrick(string CurrentStage)
    {
        switch(CurrentStage)
        {
            case "1-1":
                EmptyChart.sprite = W1S1.sprite;
                break;
            case "1-2":
                EmptyChart.sprite = W1S2.sprite;
                break;
            case "2-1":
                EmptyChart.sprite = W2S1.sprite;
                break;
            case "2-2":
                EmptyChart.sprite = W2S2.sprite;
                break;
            case "3-1":
                EmptyChart.sprite = W3S1.sprite;
                break;
            case "3-2":
                EmptyChart.sprite = W3S2.sprite;
                break;
        }
    }
}
