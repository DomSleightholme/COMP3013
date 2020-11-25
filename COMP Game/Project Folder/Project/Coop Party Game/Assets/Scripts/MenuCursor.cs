using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCursor : MonoBehaviour
{
    float depth = 10.0f;

    void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        FollowMouse();
    }

    void FollowMouse()
    {
       var mousePos = Input.mousePosition;
       var wantedPos = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, depth));
       transform.position = wantedPos;
    }
}
