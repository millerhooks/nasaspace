﻿using UnityEngine;
using System.Collections;

public class MiniMapUI : MonoBehaviour
{

    public RenderTexture miniMapTexture;
    public Material miniMapMaterial;
    public Texture miniMapBezelTexture;

    void OnGUI()
    {
        if (Event.current.type == EventType.Repaint)
        {
            float width = Screen.width / 10;
            Graphics.DrawTexture(new Rect(Screen.width - width, 0, width, Screen.height / 4), miniMapTexture, miniMapMaterial);
            Graphics.DrawTexture(new Rect(Screen.width - width, 0, width, Screen.height / 4), miniMapBezelTexture);
        }
    }
}