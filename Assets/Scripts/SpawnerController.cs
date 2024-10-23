using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private float minX;
    [SerializeField] private float maxX;

    [SerializeField] private float startTime;
    private float time;

    [SerializeField] private Sprite[] sprites;

    void Update()
    {
        if (time <= 0)
        {
            SpawnObject();
            time = startTime;
        }
        else
        {
            time -= Time.deltaTime;
        }
        
    }

    private void SpawnObject()
    {
        GameObject newPrefab = Instantiate(prefab);
        newPrefab.transform.position = new Vector2(
                Random.Range(minX, maxX),
                transform.position.y
            );

        Sprite randomSprite = sprites[Random.Range(0, sprites.Length)];
        newPrefab.GetComponent<SpriteRenderer>().sprite = randomSprite;
    }
}
