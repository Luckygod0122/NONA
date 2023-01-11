using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMapController : MonoBehaviour
{
    public GameObject GroundBar;
    private float MapLengthX;

    public GameObject BackGround;
    private float BackGroundPositionX;

    public Slider MiniMapSlider;

    // Start is called before the first frame update
    void Start()
    {
        MapLengthX = GroundBar.transform.position.x * 2;
        MiniMapSlider.maxValue = MapLengthX;
    }

    // Update is called once per frame
    void Update()
    {
        BackGroundPositionX = BackGround.transform.position.x;

        MiniMapSlider.value = (-BackGroundPositionX);
    }
}
