using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Physics3D
{
    using UnityEngine;

    public class BallisticMissile : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private float initialSpeed = 30f;
        [SerializeField] private float gravity = 9.81f;
        [SerializeField] private Rigidbody projectilePrefab;

        private void FixedUpdate()
        {
            
                Vector3 startPosition = transform.position;
                Vector3 targetPosition = target.position;
                Vector3 targetVelocity = target.GetComponent<Rigidbody>().velocity;

                float flightTime = CalculateFlightTime(startPosition, targetPosition, initialSpeed);
                Vector3 leadPoint = CalculateLeadPoint(targetPosition, targetVelocity, flightTime);
                Vector3 launchVelocity = CalculateLaunchVelocity(startPosition, leadPoint, initialSpeed, gravity);

                Rigidbody projectileInstance = Instantiate(projectilePrefab, startPosition, Quaternion.identity);
                LaunchProjectile(projectileInstance, launchVelocity);
            
        }

        private float CalculateFlightTime(Vector3 startPosition, Vector3 targetPosition, float initialSpeed)
        {
            float distance = Vector3.Distance(startPosition, targetPosition);
            return distance / initialSpeed;
        }

        private Vector3 CalculateLeadPoint(Vector3 targetPosition, Vector3 targetVelocity, float flightTime)
        {
            return targetPosition + targetVelocity * flightTime;
        }

        private Vector3 CalculateLaunchVelocity(Vector3 startPosition, Vector3 leadPoint, float initialSpeed, float gravity)
        {
            Vector3 direction = (leadPoint - startPosition).normalized;
            float distance = Vector3.Distance(startPosition, leadPoint);
            float angle = Mathf.Asin((gravity * distance) / (initialSpeed * initialSpeed)) / 2.0f;

            float yVelocity = initialSpeed * Mathf.Sin(angle);
            float xzVelocity = initialSpeed * Mathf.Cos(angle);

            Vector3 launchVelocity = direction * xzVelocity;
            launchVelocity.y = yVelocity;

            return launchVelocity;
        }

        private void LaunchProjectile(Rigidbody projectile, Vector3 launchVelocity)
        {
            projectile.velocity = launchVelocity;
        }
    }
}
