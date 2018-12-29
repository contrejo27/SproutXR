﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcCheckerTexture : MonoBehaviour
{
    public Texture2D mainTexture;

    public int mainTexWidth;
    public int mainTexHeight;

    void Start ()
    {
        SetMainTextureSize();
        CreatePattern();
    }


    void Update()
    {

    }

    void SetMainTextureSize()
    {
         mainTexture = new Texture2D(mainTexWidth, mainTexHeight);
    }

    void CreatePattern()
    {
       for (int i = 0; i < mainTexWidth; i++)
       {
           for (int j = 0; j < mainTexWidth; j++)
           {
               if (((i + j)%2)==1)
               {
                   mainTexture.SetPixel(i, j, Color.black);
               }
               else
               {
                   mainTexture.SetPixel(i, j, Color.white);
               }
           }
       }

       mainTexture.Apply();

       GetComponent<Renderer>().material.mainTexture = mainTexture;
       mainTexture.wrapMode = TextureWrapMode.Clamp;
       mainTexture.filterMode = FilterMode.Point;
    }


}
