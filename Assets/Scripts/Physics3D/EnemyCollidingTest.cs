using Assets.Scripts.Physics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollidingTest : MonoBehaviour
{
    
    private void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0,0,1);
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       
            print("Работает");
            Destroy(collision.gameObject);
        
    }
}
