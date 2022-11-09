using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionController : MonoBehaviour
{
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

    public void OptionOn()
    {
        OptionWindow.SetActive(true);
        OptionButton.SetActive(false);
    }

    public void OptionOff()
    {
        OptionWindow.SetActive(false);
        OptionButton.SetActive(true);
    }
}
