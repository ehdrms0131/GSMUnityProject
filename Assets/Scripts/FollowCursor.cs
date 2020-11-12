using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour //마우스커서가 따라오게함
{
    public GetCursorPosition cursor;

    void Update()
    {
        transform.position = cursor.mousePos;//마우스의 위치를 계속 받아옴
    }
}
