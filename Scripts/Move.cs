using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
     public float speed = 7f;
     Rigidbody rb;

     private void Start()
     {
          rb = GetComponent<Rigidbody>();
     }

     void Update()
     {
          float xPlay = Input.GetAxisRaw("Horizontal");
          float zPlay = Input.GetAxisRaw("Vertical");

          rb.velocity = new Vector3(xPlay,rb.velocity.y,zPlay) * speed;
     }

}
