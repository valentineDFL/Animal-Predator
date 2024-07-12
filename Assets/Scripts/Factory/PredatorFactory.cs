using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class PredatorFactory : AbstractFactory
    {
        public override Entity CreateEntity(Transform spawnPosition)
        {
            PredatorProduct predatorProduct = new PredatorProduct(spawnPosition);
            predatorProduct.CreateEntity();

            return predatorProduct;
        }
    }
}
