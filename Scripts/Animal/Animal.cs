using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour, Assets.Scripts.IAnimal
{
    private Rigidbody _rigidbody3D;
    private int _speed = 20;
    private Predator _die;

    private void Start()
    {
        _die = new Predator();
        _rigidbody3D = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        float moveZ = Input.GetAxis("Horizontal");
        float moveX = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(moveZ, 0, moveX);

        _rigidbody3D.MovePosition(_rigidbody3D.position + direction * _speed * Time.fixedDeltaTime);
    }
}
