using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_is_fun : MonoBehaviour
{
    float movSpeed = 2;
    public Transform pos;

    // Start is called before the first frame update
    void Start()
    {
        
    
    }
    







    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.position += Vector3.up * Time.deltaTime * movSpeed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.position += Vector3.down * Time.deltaTime * movSpeed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.position += Vector3.left * Time.deltaTime * movSpeed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.position += Vector3.right * Time.deltaTime * movSpeed;
        }
    }
}
