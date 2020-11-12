using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public PlayerWeaponManagement PWM;//무기관리
    public GetWeapon GW;//무기를 얻음
    public GameObject bulletFactory;//프리팹 총알
    public Transform muzzle;//총구위치
    
    public float fireDelay;//총 발사 이펙트의 딜레이
    public float timer;//말 그대로 타이머
    public const float minute = 60;//시간을 재는 용도 time.deltatime 이용시 공평하게 카운트 가능할듯
  
    void Start()
    {
        fireDelay = 1 / (GW.rpm / minute);// 1/얻은총의 rpm(초당연사속도)/초당=총발사속도
    }

    void Update()
    {
        if (PWM.fullAuto == false && Input.GetButtonDown("Fire1"))//무기관리 클래스의 자동발사가 꺼져있음&왼쪽마우스가 눌려있는동안
        {
            GameObject bullet = Instantiate(bulletFactory);//총알 뽑아내는 코드
            bullet.transform.position = muzzle.position; //총구위치 판단해서
            bullet.transform.right = muzzle.right;  //쏜다
        }
        else if(PWM.fullAuto == true && Input.GetButton("Fire1"))//자동발사on&왼쪽버튼을 눌렀을때
        {
            timer += Time.deltaTime; //타이머+프레임조정으로 시간 초기화
            if (fireDelay <= timer) //시간이 총딜레이보다 느릴때
            {
                GameObject bullet = Instantiate(bulletFactory);

                bullet.transform.position = muzzle.position;
                bullet.transform.right = muzzle.right;
                timer = 0;//시간초기화
            }
        }
    }
    
}
