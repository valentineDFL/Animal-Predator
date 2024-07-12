using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class AnimalFactory : AbstractFactory
    {
        public override Entity CreateEntity(Transform spawnPosition)
        {
            AnimalProduct animalProduct = gameObject.AddComponent<AnimalProduct>();
            animalProduct.Initialize(spawnPosition);
            animalProduct.CreateEntity();
            return animalProduct;
        }
    }
}
