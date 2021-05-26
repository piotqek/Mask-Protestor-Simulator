using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBGSpawnManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject friend;

    private Vector3 spawnPosLeft = new Vector3(-1, 6, 0);
    private Vector3 spawnPosRight = new Vector3(1, -6, 0);

    void Start()
    {
        InvokeRepeating("SpawnNPC", 0.25f, 0.25f);


    }

    // Update is called once per frame
    void SpawnNPC()
    {


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

}
