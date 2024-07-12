using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Predator : MonoBehaviour, Assets.Scripts.IPredator
{
    private Rigidbody _rigidBody3D;
    private AudioSource _audioSource;
    private float _speed = 20;
    private Vector3 _targetPos;
    private int _randomPosX = 0;
    private int _randomPosZ = 0;

    private void Start()
    {
        _rigidBody3D = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        _targetPos = this.gameObject.transform.position;
        _randomPosX = UnityEngine.Random.Range(-25, 25);
        _randomPosZ = UnityEngine.Random.Range(-25, 25);
    }

    private void Update()
    {
        if (Flairs(15) == true)
        {
            MoveToAnimal();
        }
        else
        {
            Move();
        }
        if(Flairs(2) == true)
        {
            AnimalEat();
        }
    }

    public void Move()
    {
        Vector3 dirToPos = new Vector3(_randomPosX, _rigidBody3D.position.y, _randomPosZ);

        if(_rigidBody3D.position != dirToPos)
        {
            _rigidBody3D.MovePosition(Vector3.MoveTowards(_rigidBody3D.position, dirToPos, _speed * Time.deltaTime));
        }
        else
        {
            _randomPosX = UnityEngine.Random.Range(-25, 25);
            _randomPosZ = UnityEngine.Random.Range(-25, 25);
        }
    }

    public bool Flairs(float distanceActivate)
    {
        if (Vector3.Distance(_rigidBody3D.position, GameObject.FindAnyObjectByType<Animal>().transform.position) <= distanceActivate)
        {
            return true;
        }
        return false;
    }

    public void MoveToAnimal()
    {
        _rigidBody3D.MovePosition(Vector3.MoveTowards(_rigidBody3D.position, FindAnyObjectByType<Animal>().transform.position, _speed * Time.deltaTime));
    }

    public void AnimalEat()
    {
        print("Вы проиграли");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
