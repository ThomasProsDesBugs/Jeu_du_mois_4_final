
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin : MonoBehaviour
{


    void quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    private void OnTriggerEnter(Collider col)

    {

        if (col.name == "First person player")
        {

            Invoke("quit", 1);


        }


    }
}
