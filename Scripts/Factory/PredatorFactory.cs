using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class PredatorFactory : AbstractFactory
    {
        public override Entity CreateEntity(Transform spawnPosition)
        {
            PredatorProduct predatorProduct = gameObject.AddComponent<PredatorProduct>(); //new PredatorProduct();
            predatorProduct.Initialize(spawnPosition);
            predatorProduct.CreateEntity();

            return predatorProduct;
        }
    }
}
