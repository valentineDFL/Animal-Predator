using UnityEngine;

namespace Assets.Scripts.Factory
{
    internal abstract class Entity : MonoBehaviour
    {
        protected Transform spawnPosition;

        public void Initialize(Transform spawnPosition)
        {
            this.spawnPosition = spawnPosition;
        }

        public abstract GameObject CreateEntity();
    }
}
