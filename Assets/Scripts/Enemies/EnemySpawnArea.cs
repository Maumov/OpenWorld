using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnArea : MonoBehaviour
{
    public List<GameObject> patrolWaypoints;
    public List<GameObject> WanderWaypoints;
    public float areaSizeForRandomWander;


    public void SpawnEnemy(GameObject enemyPrefab) {
        Instantiate(enemyPrefab,transform);
    }

    public Vector3 GetRandomWanderPosition() {
        int random = Random.Range(0, WanderWaypoints.Count);
        Debug.Log(random);
        return WanderWaypoints[random].transform.position;
    }

    public Vector3 GetRandomWaypointPosition (){
         int random = Random.Range(0, patrolWaypoints.Count);

        return patrolWaypoints[random].transform.position;
    }

}
