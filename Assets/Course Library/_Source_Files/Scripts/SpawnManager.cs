using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2;
    private float repeatRate = 2;
    public GameObject obPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void spawnObstacle()
    {
        Instantiate(obPrefab, spawnPos, obPrefab.transform.rotation);
    }
}
