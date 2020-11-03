using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    public GetCursorPosition cursor;
    void Update()
    {
        transform.position = cursor.mousePos;
        //마우스커서가 따라옴(transform.position을 이용해 마우스커서의 위치를 받음)
    }
}
