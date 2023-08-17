using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalUser : MonoBehaviour
{
    public static float screenHeight;
    public static float screenWidth;
    private void Awake()
    {
        screenHeight = Camera.main.orthographicSize * 2f;
        screenWidth = screenHeight * (float)Screen.width / (float)Screen.height;
    }
}
