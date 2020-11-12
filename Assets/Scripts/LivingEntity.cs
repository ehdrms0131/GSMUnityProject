using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour
{
    //플레이어&몹 스탯
    public float myStartingHealth;//기본 체력
    public float myStartingArmor;//기본방어력
    public float myStartingEnergyArmor;//기본 마방
    public float health;//현재 체력
    public float Armor;//현재 물방
    public float EnergyArmor;//현재 마방
    protected bool dead; //죽음유무 판단

    protected float nextArmor;//물리방어력 다음 받아낼 수치
    protected float nextEnergyArmor;//마방 다음 받아낼 수치

    void Start()
    {
        health = myStartingHealth;//시작 체력을 받아옴
        Armor = myStartingArmor;//시작 물방 받아옴
        EnergyArmor = myStartingEnergyArmor;//시작 마방 받아옴
    }

    
    protected void GetDamage(float damage, float energyDamage ,float Penetration, float EnergyPenetration)
    {
        //데미지공식
        if (100 + Armor - Penetration > 0)//방관
        {
            health -= 100 / (100 + Armor - Penetration) * damage;//방관계산식
            print(100 / (100 + Armor - Penetration) * damage + "데미지 입음");//데미지 얼마 입었는지 표시
        }
        else health -= damage;//체력감소

        if (100 + EnergyArmor - EnergyPenetration > 0)//마관
        {
            health -= 100 / (100 + EnergyArmor - EnergyPenetration) * energyDamage;//마관계산식
            print(100 / (100 + EnergyArmor - EnergyPenetration) * energyDamage + "데미지 입음");//같음
        }
        else health -= energyDamage;//체력감소

        if (Penetration >= 0)
        {
            Armor -= Penetration;
        } //오류: 적용 안됨
        if (EnergyPenetration >= 0)
        {
            EnergyArmor -= EnergyPenetration;
        } //오류: 적용 안됨
        if (health <= 0 &! dead)
        {
            dead = true;
            health = 0;
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("충돌 감지됨");//충돌감지
        GetDamage(collision.gameObject.GetComponent<PlayerBullet>().bulletDamage, 
            collision.gameObject.GetComponent<PlayerBullet>().bulletEnergyDamage,
            collision.gameObject.GetComponent<PlayerBullet>().nextBulletPenetration,
            collision.gameObject.GetComponent<PlayerBullet>().nextBulletEnergyPenetration);//방관 마관 물리탄 마법탄
    }
}
