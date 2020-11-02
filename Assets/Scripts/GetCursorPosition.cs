using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCursorPosition : MonoBehaviour
{
    public GetCursorPosition meow;
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        
        
    }
}
