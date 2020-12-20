using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimatedButton : MonoBehaviour
{
    public bool isHover;
    public float scrollSpeed;
    public Renderer BackgroundRend;

    [Header("Sizes")]
    float xSize;
    float ySize;
    public float ZoomX;
    public float ZoomY;
    public float Timer;

    private void Start()
    {
        xSize = 1;
        ySize = 1;
    }

    private void Update()
    {
        if(isHover == true)
        {
            BackgroundRend.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, scrollSpeed * Time.deltaTime);

            if (ZoomX < xSize && ZoomY < ySize)
            {
                xSize -= Timer * Time.deltaTime;
                ySize -= Timer * Time.deltaTime;
            }

            BackgroundRend.material.SetColor("_Color", Color.red);

            BackgroundRend.material.SetTextureScale("_MainTex", new Vector2(xSize, ySize));
        }
        else
        {
            BackgroundRend.material.SetTextureScale("_MainTex", new Vector2(xSize, ySize));
            BackgroundRend.material.mainTextureOffset += new Vector2(0 * Time.deltaTime, 0 * Time.deltaTime);

            if(1 > xSize && ZoomY < 1)
            {
                xSize += Timer * Time.deltaTime;
                ySize += Timer * Time.deltaTime;
            }
        }

    }


    public void HoverOn()
    {
        isHover = true;           
    }

    public void HoverOff()
    {
        isHover = false;          
    }
}
