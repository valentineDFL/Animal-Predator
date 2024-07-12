using System.Collections.Generic;
using Unity.VisualScripting;
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
            _animalFactory = new AnimalFactory();
            _animalFactory.CreateEntity(_spawnPoint1);
        }

        private void CreatePredator()
        {
            _predatorFactory = new PredatorFactory();
            for(int i = 0; i < _spawnPoint2.Count; i++)
            {        
                _predatorFactory.CreateEntity(_spawnPoint2[i]);
            }
        }
    }
}
