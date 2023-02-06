using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestJoystick : MonoBehaviour
{
    RectTransform myTransform;
    float moveSpeed = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<RectTransform>();

        
    }

    // Update is called once per frame
    void Update()
    {
        myTransform.anchoredPosition -= new Vector2(UltimateJoystick.GetHorizontalAxis("MoveMent"), Input.GetAxis("Vertical")) * moveSpeed * Time.deltaTime;
        //myTransform.position -= new Vector3(UltimateJoystick.GetHorizontalAxis("MoveMent"), Input.GetAxis("Vertical"), 0) * moveSpeed * Time.deltaTime;

        myTransform.anchoredPosition -= new Vector2(Input.GetAxis("Horizontal"), 0f) * moveSpeed * Time.deltaTime;


    }

}
