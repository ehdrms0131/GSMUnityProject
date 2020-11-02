using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterConditionManager : MonoBehaviour
{
    public float monsterHP = 100f;

    void Update()
    {
        if (monsterHP <= 0)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
