using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScreenUtilsScript 
{
    static int screenWidth;
    static int screenHeight;

    static float screenLeft;
    static float screenRight;
    static float screenTop;
    static float screenBottom;

    public static float ScreenLeft { get { return screenLeft; }}
    public static float ScreenRight { get { return screenRight; } }
    public static float ScreenTop { get { return screenTop; } }
    public static float ScreenBottom { get { return screenBottom; } }


    public static void Initialize()
    {
        float screenZ = -Camera.main.transform.position.z;
        Debug.Log(Screen.width + " " + Screen.height);
        Vector3 lowerLeftCornerScreen = new Vector3(0, 0, screenZ);
        Vector3 lowerLeftCornerWorld = Camera.main.ScreenToWorldPoint(lowerLeftCornerScreen);
        Vector3 topRightCornerScreen = new Vector3(Screen.width, Screen.height, screenZ);
        Vector3 topRightCornerWorld = Camera.main.ScreenToWorldPoint(topRightCornerScreen);

        screenLeft = lowerLeftCornerWorld.x;
        screenRight = topRightCornerWorld.x;
        screenTop = topRightCornerWorld.y;
        screenBottom = lowerLeftCornerWorld.y;
    }






}
