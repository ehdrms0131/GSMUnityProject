using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public PlayerWeaponManagement PWM;
    public GetWeapon GW;
    public GameObject bulletFactory;
    public Transform muzzle;
    
    public float fireDelay;
    public float timer;
    public const float minute = 60;
    // Start is called before the first frame update
  
    void Start()
    {
        fireDelay = 1 / (GW.rpm / minute);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PWM.fullAuto == false && Input.GetButtonDown("Fire1"))
        {
           
            GameObject bullet = Instantiate(bulletFactory);
            
            bullet.transform.position = muzzle.position;
            bullet.transform.right = muzzle.right;
           
        }
        else if(PWM.fullAuto == true && Input.GetButton("Fire1"))
        {
            timer += Time.deltaTime;
            if (fireDelay <= timer)
            {
               
                GameObject bullet = Instantiate(bulletFactory);

                bullet.transform.position = muzzle.position;
                bullet.transform.right = muzzle.right;
                timer = 0;
               
            }

        }
    }
    
}
