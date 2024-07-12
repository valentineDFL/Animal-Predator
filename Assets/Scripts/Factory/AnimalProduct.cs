using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class AnimalProduct : Entity
    {
        public AnimalProduct(Transform spawnPosition) : base(spawnPosition) { }

        public override GameObject CreateEntity()
        {
            var animalPrefab = Resources.Load<GameObject>("Animal");
            var animalPrefabDraw = GameObject.Instantiate(animalPrefab, SpawnPosition.position, Quaternion.identity);
            
            return animalPrefabDraw;
        }
    }
}
