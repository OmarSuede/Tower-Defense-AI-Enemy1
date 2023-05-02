using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 13f;//can be removed after adding enemy script

    private Transform target;

    private int wavePoint = 0;

    void Start()
    {
        target = Waypoints.Waypoint[0];
    }
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized*speed*Time.deltaTime, Space.World);
        if(Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

    }

     void GetNextWaypoint()
        {
            if(wavePoint>= Waypoints.Waypoint.Length-1)
            {
                EndPath();
                return;
            }
            wavePoint++;
            target = Waypoints.Waypoint[wavePoint];
        }
    void EndPath()
	{
		//TAKE HEALTH FROM PLAYER
		WaveSpawner.EnemiesAlive--;
		Destroy(gameObject);
	}
}
