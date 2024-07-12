using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal abstract class AbstractFactory
    {
        protected Transform spawnPosition;

        public void Initialize(Transform spawnPosition)
        {
            this.spawnPosition = spawnPosition;
        }

        public abstract Entity CreateEntity(Transform spawnPosition);
    }
}
