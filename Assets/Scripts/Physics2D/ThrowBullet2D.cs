using Assets.Scripts.Physics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class ThrowBullet2D : MonoBehaviour
{
    [SerializeField] private Transform _spawnPos;
    [SerializeField] private Transform _targetPos;

    [SerializeField] private float _angle;
    [SerializeField] private GameObject _bullet;

    private const float _g = 9.8f;
    private float _radians;

    private GameObject _newBullet;


    private void Start()
    {
        Time.timeScale = 0.8f;
    }

    // узнать разницу между Quaternion и углами Euler

    private void Update()
    {
        _spawnPos.localEulerAngles = new Vector3(0, 0, _angle);
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnBullet();
        }
    }

    private void FixedUpdate()
    {
        if(_newBullet != null)
        {
            _newBullet.transform.rotation = Quaternion.Euler(0f, 0f, MoveAngeInDegree());
            print(MoveAngeInDegree());
        }  
    }

    private Vector2 BulletVelocity()
    {
        Vector2 fromTo = _targetPos.position - transform.position;
        Vector2 fromToXZ = new Vector2(fromTo.x, fromTo.y);

        float x = fromToXZ.magnitude;
        float y = fromTo.y;

        float AngleInRadians = _angle * Mathf.PI / 180;

        float v2 = (_g * x * x) / (2 * (y - Mathf.Tan(AngleInRadians) * x) * Mathf.Pow(Mathf.Cos(AngleInRadians), 2));
        float v = Mathf.Sqrt(Mathf.Abs(v2));
        Vector2 launchVelocity = (transform.right * Mathf.Cos(AngleInRadians) + transform.up * Mathf.Sin(AngleInRadians)) * v;

        return launchVelocity;
    }

    private GameObject SpawnBullet()
    {
        _newBullet = Instantiate(_bullet, _spawnPos.position, Quaternion.identity);
        _newBullet.GetComponent<Rigidbody2D>().velocity = BulletVelocity();
        //_newBullet.transform.rotation = Quaternion.Euler(0f, 0f, _angle);
        return _newBullet;
    }

    private float MoveAngeInDegree()
    {

        Vector2 dir = new Vector2(_targetPos.transform.position.x - _newBullet.transform.position.x,
        _targetPos.transform.position.y - _newBullet.transform.position.y);

        float arcTg = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        return arcTg;
    }


    
}
