using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject cutPrefab;
    public float cutLifeTime;

    private bool draggeing;

    private Vector2 swipStart;

    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            draggeing = true;
            swipStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        }
        else if(Input.GetMouseButtonUp(0) && draggeing)
        {
            draggeing = false;
            cutSpawner();
        }
    }

    private void cutSpawner()
    {
        Vector2 swipEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject cutInstance = Instantiate(cutPrefab, swipStart, Quaternion.identity);

        cutInstance.GetComponent<LineRenderer>().SetPosition(0, swipStart);
        cutInstance.GetComponent<LineRenderer>().SetPosition(1, swipEnd);

        Vector2[] colaiderPoint = new Vector2[2];
        colaiderPoint[0] = Vector2.zero;
        colaiderPoint[1] = swipEnd - swipStart;

        cutInstance.GetComponent<EdgeCollider2D>().points = colaiderPoint;

        Destroy(cutInstance, cutLifeTime);

    }
}
