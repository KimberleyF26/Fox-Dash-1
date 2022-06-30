using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private CharacterController controller;
    private float speed = 7f;
    private Vector3 moveVector;
    /*private float verticalVelocity = 0.0f;
    public float gravity = 5f;*/
    

    void Start (){
        controller = GetComponent<CharacterController> ();
    }

    void Update()
    {
        moveVector = Vector3.zero;

        /*if(controller.isGrounded)
        {
            verticalVelocity = 1f;
        }

        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }*/

        moveVector.x = Input.GetAxisRaw("Horizontal") * speed;
       //moveVector.y = verticalVelocity;
        moveVector.z = speed;

        controller.Move (moveVector * Time.deltaTime);
    }


   private void OnTriggerEnter(Collider other)
   {
    if (other.gameObject.tag == "Coin")
    {

        GameManager.Instance.CollectCoin();
        Debug.Log("You have:" + GameManager.Instance.GetCoinsCollected());

        Destroy(other.gameObject);

    }

   }
}
