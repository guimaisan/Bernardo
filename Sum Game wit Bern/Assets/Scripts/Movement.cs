using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviour
{
    Rigidbody2D Rigidbody;
    float movSpeed;
    Vector3 moveDir;
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
        Rigidbody = GetComponent<Rigidbody2D>();
        movSpeed = 2;
        
    }
    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        if (view.IsMine)
        {
            if (Input.GetKey(KeyCode.A))
            {
                moveX = -1f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveX = 1f;
            }
            if (Input.GetKey(KeyCode.W))
            {
                moveY = 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveY = -1f;
            }
            moveDir = new Vector3(moveX, moveY).normalized;
        }
       
    }

    private void FixedUpdate()
    {
        if (view.IsMine)
        {
            GetComponent<Rigidbody2D>().MovePosition(transform.position + moveDir * movSpeed * Time.fixedDeltaTime);
        }
    }


}
