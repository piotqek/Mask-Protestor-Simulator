using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject checker;

    // Start is called before the first frame update
    void Start()
    {

    }

    //not necessary script for mobile release, left only for easier in-engine testing
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            checker.transform.position = new Vector3(-1, transform.position.y, checker.transform.position.z);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            checker.transform.position = new Vector3(1, transform.position.y, checker.transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            checker.transform.position = new Vector3(0, transform.position.y, checker.transform.position.z);
        }
    }



}