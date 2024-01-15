using UnityEngine;

namespace Pattern.Singleton
{
    public class SingletonGeneric<T> : MonoBehaviour where T : SingletonGeneric<T>
    {
        static T instance;

        public static T Instance
        {
            get
            {
                if (instance != null) return instance;

                T sceneComponent = FindObjectOfType<T>();

                Instance = sceneComponent;
                return instance;
            }
            private set
            {
                instance = value;
                if (instance != null) instance.TryInit();
            }
        }

        bool isInitialized;

        bool IsInstance => ReferenceEquals(instance, GetComponent<T>());

        protected virtual void Awake()
        {
            if (instance is null)
            {
                Instance = GetComponent<T>();
            }
            else if (!IsInstance)
            {
                Destroy(gameObject);
            }
        }

        protected virtual void OnDestroy()
        {
            if (IsInstance)
            {
                Instance = null;
            }
        }

        void TryInit()
        {
            if (isInitialized) return;
            isInitialized = true;

            InitializeComponent();
        }

        protected virtual void InitializeComponent() { }
    }

}
