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

    public GameObject Star1Image;
    public GameObject Star2Image;
    public GameObject Star3Image;

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

            Star1Image.SetActive(false);
            Star2Image.SetActive(false);
            Star3Image.SetActive(false);
        }
        else
        {
            if (DataManager.Instance.data.IfUnlock[StageNumber] == true)
            {
                StageStartButton.SetActive(true);
                switch(DataManager.Instance.data.StageScore[StageNumber])
                {
                    case 0:
                        Star1Image.SetActive(false);
                        Star2Image.SetActive(false);
                        Star3Image.SetActive(false);
                        break;
                    case 1:
                        Star1Image.SetActive(true);
                        Star2Image.SetActive(false);
                        Star3Image.SetActive(false);
                        break;
                    case 2:
                        Star1Image.SetActive(true);
                        Star2Image.SetActive(true);
                        Star3Image.SetActive(false);
                        break;
                    case 3:
                        Star1Image.SetActive(true);
                        Star2Image.SetActive(true);
                        Star3Image.SetActive(true);
                        break;
                }
            }
            else
            {
                StageStartButton.SetActive(false);
                Star1Image.SetActive(false);
                Star2Image.SetActive(false);
                Star3Image.SetActive(false);
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
