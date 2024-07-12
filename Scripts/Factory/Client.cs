using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class Client : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint1;
        [SerializeField] private List<Transform> _spawnPoint2;
        private AbstractFactory _animalFactory;
        private AbstractFactory _predatorFactory;


        private void Start()
        {
            CreateAnimal();
            CreatePredator();
        }

        private void CreateAnimal()
        {
            _animalFactory = gameObject.AddComponent<AnimalFactory>();
            _animalFactory.CreateEntity(_spawnPoint1); 
            // _spawnPoint1
        }

        private void CreatePredator()
        {
            _predatorFactory = gameObject.AddComponent<PredatorFactory>();
            for(int i = 0; i < _spawnPoint2.Count; i++)
            {        
                _predatorFactory.CreateEntity(_spawnPoint2[i]);
                // _spawnPoint2[i]
            }
        }
    }
}
