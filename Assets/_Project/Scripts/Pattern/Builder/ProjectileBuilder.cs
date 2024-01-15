using UnityEngine;

public class ProjectileBuilder
{
    private GameObject _prefab;

    public ProjectileBuilder WithPrefab(GameObject prefab)
    {
        this._prefab = prefab;
        return this;
    }

    public GameObject Build(Transform origin)
    {
        GameObject projectile = GameObject.Instantiate(this._prefab);
        return projectile;
    }
}
