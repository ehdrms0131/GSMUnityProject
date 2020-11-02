using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpspeed = 5f;
    public float playerMovementSpeed = 10f;
    public float playerHorizontalMovement;
    public float playerVerticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHorizontalMovement = Input.GetAxis("Horizontal");
        playerVerticalMovement = Input.GetAxis("Vertical");
        Vector3 dir = Vector3.right * playerHorizontalMovement + Vector3.up * playerVerticalMovement;
        transform.position = transform.position + dir * playerMovementSpeed * Time.deltaTime;
    }
}
