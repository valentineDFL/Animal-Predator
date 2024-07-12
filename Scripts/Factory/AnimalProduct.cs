using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal class AnimalProduct : Entity
    {
        public override GameObject CreateEntity()
        {
            var animalPrefab = Resources.Load<Animal>("Animal");
            var animalPrefabDraw = Instantiate(animalPrefab, spawnPosition.position, Quaternion.identity);
            
            return animalPrefabDraw.gameObject;
        }
    }
}
