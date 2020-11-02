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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")) {
            Debug.Log("플레이어가 무기를 획득했습니다");
            PW.firstWeapon = weaponName;
            Destroy(gameObject);
        }
    }

}
