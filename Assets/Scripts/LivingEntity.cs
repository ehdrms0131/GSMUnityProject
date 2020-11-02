using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingEntity : MonoBehaviour
{
    public float myStartingHealth;
    public float myStartingArmor;
    public float myStartingEnergyArmor;
    public float health;
    public float Armor;
    public float EnergyArmor;
    protected bool dead;

    protected float nextArmor;
    protected float nextEnergyArmor;



    void Start()
    {
        health = myStartingHealth;
        Armor = myStartingArmor;
        EnergyArmor = myStartingEnergyArmor;
    }

    
    protected void GetDamage(float damage, float energyDamage ,float Penetration, float EnergyPenetration)
    {
        

        if (100 + Armor - Penetration > 0)
        {
            health -= 100 / (100 + Armor - Penetration) * damage;
            print(100 / (100 + Armor - Penetration) * damage + "데미지 입음");
        }
        else health -= damage;
        if (100 + EnergyArmor - EnergyPenetration > 0)
        {
            
            health -= 100 / (100 + EnergyArmor - EnergyPenetration) * energyDamage;
            print(100 / (100 + EnergyArmor - EnergyPenetration) * energyDamage + "데미지 입음");
        }
        else health -= energyDamage;

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
        print("충돌 감지됨");
        GetDamage(collision.gameObject.GetComponent<PlayerBullet>().bulletDamage, 
            collision.gameObject.GetComponent<PlayerBullet>().bulletEnergyDamage,
            collision.gameObject.GetComponent<PlayerBullet>().nextBulletPenetration,
            collision.gameObject.GetComponent<PlayerBullet>().nextBulletEnergyPenetration);
    }

  

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
