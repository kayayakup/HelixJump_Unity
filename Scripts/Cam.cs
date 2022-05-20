using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

    public Transform ball;
    public Manager manage;

    Vector3 newCoordinates;
    List<GameObject> obstacles;







    private void Awake()
    {
        newCoordinates = transform.position;
        obstacles = new List<GameObject>();

        GameObject[] flats = GameObject.FindGameObjectsWithTag("Red_Cube");

        foreach(GameObject flat in flats)
        {
            obstacles.Add(flat);
        }

        manage.sumObstacles = (float)obstacles.Count;
    }

    // Update is called once per frame
    void Update()
    {   
        foreach (GameObject coordinate in obstacles)
        {
            if (ball.position.y <= coordinate.transform.position.y)
            {
                manage.letObstacle();
                obstacles.Remove(coordinate);
                newCoordinates -= new Vector3(0, 1.5f, 0);
            }
        }
        transform.position = Vector3.Lerp(transform.position, newCoordinates, Time.deltaTime);
    }
}
