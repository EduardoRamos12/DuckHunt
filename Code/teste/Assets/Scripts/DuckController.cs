using UnityEngine;
using System.Collections;

public class DuckController : LivingEntity
{

    public float duckSpeed = 1;

    public Vector3[] limits;

    private Vector3 waypoint;


    // Use this for initialization
    void Start()
    {
        
        GenerateNewWaypoint();
    }

    void FixedUpdate()
    {
        if (transform.position != waypoint)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoint, duckSpeed * Time.deltaTime);
        }
        else
        {
            GenerateNewWaypoint();
        }

        transform.LookAt(waypoint);
    }

    private void GenerateNewWaypoint()
    {
        waypoint = new Vector3(Random.Range(limits[0].x, limits[1].x), Random.Range(limits[0].y, limits[1].y), Random.Range(limits[0].z, limits[1].z));
    }
}