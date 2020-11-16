using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCursorPosition : MonoBehaviour
{
    public GetCursorPosition meow;
    public Vector3 mousePos; //마우스위치를 Vector3로 받음
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    }
}
