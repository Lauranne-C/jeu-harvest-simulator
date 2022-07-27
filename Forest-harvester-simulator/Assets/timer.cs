using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private int width, height;
    private Rect rect;
    private GUIStyle labelStyle;
    private string currentTime;
    private int minutes = 0;
    private int seconds = 0;
    public Text time;

    void Awake()
    {
     
    }

    void Update()
    {
        // Obtain the current time.
        currentTime = Time.timeSinceLevelLoad.ToString("f0");
        seconds = int.Parse(currentTime);
        minutes = seconds / 60;
        seconds = seconds - (minutes * 60);
        currentTime = "" + minutes + " : " + seconds;

        time.text = currentTime;
    }
}
