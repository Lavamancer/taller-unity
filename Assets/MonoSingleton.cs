using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T> {

    private static T _instance;

    public static T Instance {
        get {
            if (_instance == null) Debug.LogError(typeof(T) + " is null");
            return _instance;
        }
    }

    private void Awake() {
        _instance = this as T;
        Init();
    }

    public virtual void Init() {
        // todo implement by inherit classes
    }
}
