using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{
    public float destroyDelay = 2.0f;

    void Start()
    {
        Destroy(gameObject, destroyDelay);
    }
}