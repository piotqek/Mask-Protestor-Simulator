using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsPoints : MonoBehaviour
{
    //public GameObject checker;
    //nie moge dac checkera bo to by wymagalo niewydajnego szukania checkera jako obiektu

    public bool wasHit = false;
    private float lowerBound = -6f;
    public GameObject buttonController;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < lowerBound)
        {
            CheckifGameOverAndDestroyObject();
        }
    }

    public void Hit()
    {
        wasHit = true;
        //Debug.Log("IsHit() dziala");
    }

    void CheckifGameOverAndDestroyObject()
    {
        if (!wasHit)
        {
            //Debug.Log("game over");
            buttonController = GameObject.FindGameObjectWithTag("ButtonController");
            buttonController.GetComponent<ButtonController>().GameOver(0);
        }
        Destroy(gameObject);
    }

}