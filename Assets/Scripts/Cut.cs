using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Fruit")
        {
            gameManager.GameScore();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == "Bom")
        {
            gameManager.RestartGame();
        }
    }
}
