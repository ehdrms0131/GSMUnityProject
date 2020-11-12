using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GetCursorPosition : MonoBehaviour
{
    public GetCursorPosition meow;//시발 고양이
    public Vector3 mousePos;//벡터포지션

    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        //마우스포지션을 받음
        //카메라의 화면 월드 포인트를 나가지 않음,vector3로 대각선값도 연산
    }
}