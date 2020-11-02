using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponManagement : MonoBehaviour
{
    public GetWeapon GW;
    public string firstWeapon = "EMPTY";
    public string secondWeapon = "EMPTY";
    public string subWeapon = "EMPTY";
    public bool fullAuto = false;
    public enum usingWeapon
    {
        // 주무장 1 : 1, 주무장 2 : 2, 보조무장(근접무기) : 3, 맨손 : 4
        mainWeapon1 = 1,
        mainWeapon2 = 2,
        meeleWeapon = 3,
        bareHandsForGay = 4
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (fullAuto == false) // 현재 단발모드일 경우
            {
                fullAuto = true; // 연발로 세팅
            }
            else if (fullAuto == true) //현재 연사모드일 경우
            {
                fullAuto = false; // 단발로 세팅
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Q를 1초동안 홀딩하면 현재 자신이 들고 있는 아이템을 버리게 하고 싶다.

            //현재 자신이 들고 있는 아이템이 무엇인가?
            //usingWeapon playerWeapon;

            //switch(playerWeapon)
            //{
            //    case mainWeapon1:
            //}
        } 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Weapon"))
        {
            print("무기를 획득했습니다."+ collision.gameObject.name);
            
        }
    }
}
