using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter( Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Fox hits rock");
           /* movement.enables = false;
            FindObjectOfType<GameManager>().EndGame();*/
        }
    }
}
