using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollidingTest2D : MonoBehaviour
{
    private int _bulletCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
