using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeaponAim : MonoBehaviour
{
    Vector3 len;
    public Vector3 mousePos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //len = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        len = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z)) - transform.position;
        float z = Mathf.Atan2(len.y, len.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.Euler(0f, 0f, z);
    }
}
