using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RandomSpawner : MonoBehaviour
{
    public GameObject prefabs;
    public List<GameObject> spawnedObjects;
    private InputAction spawnAction;

    private void Awake()
    {
        spawnAction = new InputAction("Spawn", binding: "<Keyboard>/a");
        spawnAction.Enable();
    }

    private void Start()
    {
        foreach (var obj in spawnedObjects)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
        }
        for (int i = 0; i < 3; i++)
        {
            Spawn();
        }
    }
    private void Update() {
        if (spawnAction.WasPressedThisFrame())
        {
            Spawn();
        }
    }
    void Spawn()
    {
        Instantiate(prefabs, transform.position, Quaternion.identity);
    }
}
