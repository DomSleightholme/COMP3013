using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedBackground : MonoBehaviour
{
    public float scrollSpeed;
    public Renderer BackgroundRend;

    // Update is called once per frame
    void Update()
    {
        BackgroundRend.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, scrollSpeed * Time.deltaTime);
    }
}
