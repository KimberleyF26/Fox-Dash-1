using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public float rand;
    public float Quantity;
    public float NextSpawn;
    Vector2 Place;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > NextSpawn)
        {
            NextSpawn = Time.time + Quantity;
            rand = Random.Range(-2.3f,4.3f);
            Place = new Vector2(rand,transform.position.x);
            Instantiate(Enemy,Place,Quaternion.identity);
        }
    }
}
