using System;
using UnityEngine;
using UnityEngine.UI;

public class TimeUI : MonoBehaviour
{
    private Text timeTxt;

    private void Awake()
    {
        timeTxt = GetComponent<Text>();
    }

    private void Update()
    {
        timeTxt.text = GetTime();
    }

    private string GetTime()
    {
        return DateTime.Now.ToString(("HH:mm:ss tt"));
    }
}
