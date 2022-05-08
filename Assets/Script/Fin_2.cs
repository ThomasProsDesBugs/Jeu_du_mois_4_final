using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fin_2 : MonoBehaviour
{
    public AudioSource Spotted;

    void quit()
    {
        Debug.Log("spotted");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    private void OnTriggerEnter(Collider col)

    {

        if (col.name == "First person player")
        {
            Spotted.Play();
            
            Invoke("quit", 3);


        }


    }
}
