using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float startDelay = 2;
    private float repeatRate = 2;
    public GameObject obPrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void spawnObstacle()
    { if (playerControllerScript.gameOver == false) { }
        Instantiate(obPrefab, spawnPos, obPrefab.transform.rotation); }
    }

