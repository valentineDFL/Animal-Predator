using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal abstract class Entity
    {
        protected Transform SpawnPosition;

        public Entity(Transform spawnPosition)
        {
            this.SpawnPosition = spawnPosition;
        }

        public abstract GameObject CreateEntity();
    }
}
