using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    //public GetWeapon GW;
    public float bulletSpeed = 30f;
    public float lifetime = 10; // 총알의 수명 (0 이하가 되면 파괴)
    public float bulletDamage = 10f; //총알의 데미지
    public float bulletEnergyDamage = 10f; //총알의 에너지 데미지


    public float bulletPenetration = 1; // 총알의 물리 관통력
    public float bulletEnergyPenetration = 1f; //총알의 에너지 관통력

    public float nextBulletPenetration; //총알의 관통 판정 이후의 관통력
    public float nextBulletEnergyPenetration; // 총알의 관통 판정 이후의 에너지 관통력

    public bool dead = false;
    //무기에서 근접인지 원거리인지 / 물리인지 에너지인지 상속할 것임.
    protected float damage;
    void Start()
    {
        nextBulletPenetration = bulletPenetration;
        nextBulletEnergyPenetration = bulletEnergyPenetration;
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime; //수명을 깎음.
        transform.position += transform.right * bulletSpeed * Time.deltaTime;
        if (lifetime <= 0 &! dead)
        {
            dead = true;
            Destroy(gameObject);
        }
        if(bulletPenetration < 0)
        {
            dead = true;
            Destroy(gameObject);
        }
        if(bulletEnergyPenetration < 0 &!dead)
        {
            dead = true;
            Destroy(gameObject);
        }
    }
    protected void Penetration(float Armor, float EnergyArmor)
    {
        if (bulletPenetration >= 0)
        {
            nextBulletPenetration -= Armor;
        }
        if (bulletEnergyPenetration >= 0)
        {
            nextBulletEnergyPenetration -= EnergyArmor;
        }
        
    }
    protected void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<LivingEntity>().Armor -= bulletPenetration;
        collision.gameObject.GetComponent<LivingEntity>().EnergyArmor -= bulletEnergyPenetration;
        Penetration(collision.gameObject.GetComponent<LivingEntity>().Armor, collision.gameObject.GetComponent<LivingEntity>().EnergyArmor);
        bulletPenetration = nextBulletPenetration;
        bulletEnergyPenetration = nextBulletEnergyPenetration;
        
    }
    

   
 


}
