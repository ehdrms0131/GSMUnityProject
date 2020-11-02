using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GetWeapon : MonoBehaviour
{
    public PlayerWeaponManagement PW;
    public string weaponName = "Micro_Uzi";//무기 이름
    public float rpm = 600; //초당공격속도
    public float bulletSpeed = 10f; //총알 속도

    public void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) {
            Debug.Log("플레이어가 무기를 획득했습니다");
            PW.firstWeapon = weaponName;
            Destroy(gameObject);
        }
    }

}
