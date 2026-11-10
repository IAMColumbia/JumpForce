using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    { if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else
        {
            speed = 0;
        }
   
    }
}
