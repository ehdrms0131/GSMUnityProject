using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterConditionManager : MonoBehaviour
{
    public float monsterHP = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (monsterHP <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
