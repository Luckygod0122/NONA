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

    private Vector3 LeftPos;
    private Vector3 RightPos;

    // Start is called before the first frame update
    void Start()
    {
        LeftPos = new Vector3(-1920, 0, 0);
        RightPos = new Vector3(1920, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveStageLeftside(GameObject Stage1, GameObject Stage2)
    {
        Stage2.SetActive(true);
        Stage2.transform.Translate(RightPos);
        Stage1.transform.Translate(LeftPos);
        Stage1.SetActive(false);
    }
}
