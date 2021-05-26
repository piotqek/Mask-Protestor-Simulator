using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Spawn ->int config explanation
 * 0 nothing spawns
 * 1 enemy spawns on left
 * 2 enemy spawns on right
 * 3 friend spawns on left
 * 4 friend spawns on right
 * 5 enemy on left friend on right
 * 6 5 other way around
*/

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject friend;
    public GameObject backgroundRow;
    private Vector3 spawnPosLeft = new Vector3(-1, 6, 0);
    private Vector3 spawnPosRight = new Vector3(1, 6, 0);
    private Vector3 spawnPosBG = new Vector3(0, 6, 1);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNPC", 0.25f, 0.25f);
        //below is supposed to be BG spawner
        //InvokeRepeating("SpawnBG", 0.38f, 0.4f);
        InvokeRepeating("SpawnBG", 0.19f, 0.2f);
    }

    // Update is called once per frame
    void SpawnNPC()
    {
        //var A = (1, 1);
        //var A = (1, 1);

        int config = Random.Range(0, 7);

        switch (config)
        {
            case 0:
                //nothing happens
                break;
            case 1:
                Instantiate(enemy, spawnPosLeft, enemy.transform.rotation);
                break;
            case 2:
                Instantiate(enemy, spawnPosRight, enemy.transform.rotation);
                break;
            case 3:
                Instantiate(friend, spawnPosLeft, friend.transform.rotation);
                break;
            case 4:
                Instantiate(friend, spawnPosRight, friend.transform.rotation);
                break;
            case 5:
                Instantiate(enemy, spawnPosLeft, enemy.transform.rotation);
                Instantiate(friend, spawnPosRight, friend.transform.rotation);
                break;
            default:
                Instantiate(enemy, spawnPosRight, enemy.transform.rotation);
                Instantiate(friend, spawnPosLeft, friend.transform.rotation);
                break;

        }

    }

    void SpawnBG()
    {
        Instantiate(backgroundRow, spawnPosBG, backgroundRow.transform.rotation);
    }
}
