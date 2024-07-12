using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class PredatorProduct : Entity
    {
        public PredatorProduct(Transform spawnPos) : base(spawnPos) { }

        public override GameObject CreateEntity()
        {
            var predatorPrefab = Resources.Load<GameObject>("Predator");
            var predatorPrefabDraw = GameObject.Instantiate(predatorPrefab, SpawnPosition.position, Quaternion.identity);

            return predatorPrefabDraw;
        }
    }
}
