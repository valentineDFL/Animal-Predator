using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class AnimalFactory : AbstractFactory
    {
        public override Entity CreateEntity(Transform spawnPosition)
        {
            AnimalProduct animalProduct = new AnimalProduct(spawnPosition);
            animalProduct.CreateEntity();
            return animalProduct;
        }
    }
}
