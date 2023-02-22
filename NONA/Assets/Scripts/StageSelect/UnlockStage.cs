using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockStage : MonoBehaviour
{
    public GameObject Current;
    public int StageNumber = 0;


    public StageSelectController StageSelectControllerScript;

    public GameObject StageStartButton;
    public StageSelectMove StageSelectMoveScript;

    // Start is called before the first frame update
    void Start()
    {
        DataManager.Instance.data.IfUnlock[0] = true;
    }

    // Update is called once per frame
    void Update()
    {
        Current = GetComponent<StageSelectController>().CurrentStage;

        ActiveUnlockStage();

        if ((StageSelectMoveScript.TimeCount <= 1f))
        {
            StageStartButton.SetActive(false);
        }
        else
        {
            if (DataManager.Instance.data.IfUnlock[StageNumber] == true)
            {
                StageStartButton.SetActive(true);
            }
            else
            {
                StageStartButton.SetActive(false);
            }
        }
    }


    public void ActiveUnlockStage()
    {
        switch (Current.name)
        {
            case "1-1":
                StageNumber = 0;
                break;
            case "1-2":
                StageNumber = 1;
                break;
            case "2-1":
                StageNumber = 2;
                break;
            case "2-2":
                StageNumber = 3;
                break;
            case "3-1":
                StageNumber = 4;
                break;
            case "3-2":
                StageNumber = 5;
                break;
        }
    }

}
