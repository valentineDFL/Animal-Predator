using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class PredatorProduct : Entity
    {
        public override GameObject CreateEntity()
        {
            var predatorPrefab = Resources.Load<Predator>("Predator");
            var predatorPrefabDraw = Instantiate(predatorPrefab, spawnPosition.position, Quaternion.identity);
            // _spawnPosition.position
            return predatorPrefabDraw.gameObject;
        }
    }
}
