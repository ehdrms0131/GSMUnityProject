using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GetWeapon : MonoBehaviour
{
    public PlayerWeaponManagement PW;
    public string weaponName = "Micro_Uzi";
    public float rpm = 600;
    public float bulletSpeed = 10f;
    public void OnCollisionEnter2D (Collision2D collision)//접촉유무
    {
        if (collision.collider.CompareTag("Player")) 
        {
            Debug.Log("플레이어가 무기를 획득했습니다");
            PW.firstWeapon = weaponName; //플레이어 무기에 무기이름을 받아옴
            Destroy(gameObject); //없애버려 그냥~
        }
    }

}
