using System;
using System.Collections;
using System.Collections.Generic;
using ModernProgramming;
using UnityEngine;
using UnityEngine.UI;

public class DarkModeDemo : MonoBehaviour
{
    public Camera mainCamera;
    public Text modeLabel;

    private void Start()
    {
        switch (DarkMode.CurrentMode)
        {
            case DarkMode.Mode.Dark:
                ShowDarkModeColors();
                break;
            case DarkMode.Mode.Light:
                ShowLightModeColors();
                break;
            case DarkMode.Mode.Unspecified:
                ShowUnspecifiedColors();
                break;
            default:
                break;
        }
    }

    private void ShowDarkModeColors()
    {
        mainCamera.backgroundColor = Color.black;
        modeLabel.color = Color.white;

        modeLabel.text = "CurrentMode = Mode.Dark";
    }

    private void ShowLightModeColors()
    {
        mainCamera.backgroundColor = Color.white;
        modeLabel.color = Color.black;
        
        modeLabel.text = "CurrentMode = Mode.Light";
    }

    private void ShowUnspecifiedColors()
    {
        mainCamera.backgroundColor = Color.grey;
        modeLabel.color = Color.black;
        
        modeLabel.text = "CurrentMode = Mode.Unspecified";
    }
}
