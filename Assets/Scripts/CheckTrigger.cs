using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//probably one of more important scripts, should have been called gamecontroller or something but it grew

public class CheckTrigger : MonoBehaviour
{

    public GameObject text;
    public GameObject buttonController;
    void OnTriggerExit2D(Collider2D other)
    {

        if (other.tag == "Friend")
        {
            //komentarz ochrzanionego przyjaciela
            buttonController.GetComponent<ButtonController>().GameOver(1);
        }
        else
        {
            //dymek ze drzemy ryja na zamaskowanego
            other.GetComponent<DestroyOutOfBoundsPoints>().Hit();
            text.GetComponent<CounterController>().IncreaseCount();
        }

    }
}
