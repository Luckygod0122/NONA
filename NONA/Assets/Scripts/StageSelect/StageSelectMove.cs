using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageSelectMove : MonoBehaviour
{
    public GameObject W1S1;
    public GameObject W1S2;
    public GameObject W2S1;
    public GameObject W2S2;
    public GameObject W3S1;
    public GameObject W3S2;

    private Vector3 CenterPos;
    private Vector3 RightPos;
    private Vector3 BottomPos = new Vector3(0, -1080, 0);

    public bool ifLeftButton;
    public bool ifRightButton;
    public bool ifMoveWorld = false;

    public GameObject CurrentStage;
    public GameObject SameWorldStage;
    public GameObject Button;
    public GameObject CurrentWorld;
    public GameObject NextWorld;
    public GameObject WorldButtons;

    private float Speed;
    public float TimeCount;

    public GameObject WorldSelectTrickScript;
    public GameObject StageStartButton;

    // Start is called before the first frame update
    void Start()
    {
        CenterPos = Vector3.zero;
        RightPos = new Vector3(1920, 0, 0);
//        BottomPos = new Vector3(0, -1080, 0);

        Speed = 1920f;
        TimeCount = 0f;

        ifRightButton = false;
        ifLeftButton = false;
//        ifMoveWorld = false;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;

        if (ifRightButton == true)
        {
            CurrentStage.transform.position += Vector3.MoveTowards(CenterPos, RightPos, Speed * Time.deltaTime);
        }
        if (ifLeftButton == true)
        {
            SameWorldStage.transform.position += Vector3.MoveTowards(CenterPos, -RightPos, Speed * Time.deltaTime);
        }
        if (ifMoveWorld == true)
        {
            NextWorld.transform.position += Vector3.MoveTowards(CenterPos, new Vector3(0,1080,0), 1080f * Time.deltaTime);
        }

        if ((TimeCount >= 1f) && (ifLeftButton == true || ifRightButton == true))
        {
            CurrentStage.SetActive(false);
            ifRightButton = false;
            ifLeftButton = false;
            Button.SetActive(true);
            StageStartButton.SetActive(true);
        }
        if ((TimeCount >= 1f) && (ifMoveWorld == true))
        {
            ifMoveWorld = false;
            Button.SetActive(true);
            StageStartButton.SetActive(true);
            WorldButtons.SetActive(true);
        }

    }

    public void MoveStage2(GameObject Stage1, GameObject Stage2, GameObject LeftButton)
    {
        CurrentStage = Stage1;
        SameWorldStage = Stage2;
        Button = LeftButton;

        StageStartButton.SetActive(false);

        SameWorldStage.SetActive(true);

        ifRightButton = true;
        TimeCount = 0f;
    }

    public void MoveStage1(GameObject Stage2, GameObject Stage1, GameObject RightButton)
    {
        CurrentStage = Stage2;
        SameWorldStage = Stage1;
        Button = RightButton;

        StageStartButton.SetActive(false);

        SameWorldStage.transform.localPosition = (RightPos);
        SameWorldStage.SetActive(true);

        ifLeftButton = true;
        TimeCount = 0f;
    }

    public void MoveWorld(GameObject CurrentStage, GameObject WorldStage1, GameObject RightButton)
    {
        WorldSelectTrickScript.GetComponent<WorldSelectTrick>().EmptyChartTrick(CurrentStage.name);
        NextWorld = WorldStage1;
        NextWorld.transform.localPosition = BottomPos;
        Button = RightButton;

        StageStartButton.SetActive(false);
        WorldButtons.SetActive(false);

        NextWorld.SetActive(true);

        ifMoveWorld = true;
        TimeCount = 0f;
    }
}
