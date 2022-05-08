using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alternate : MonoBehaviour
{
    public GameObject Light;
    public AudioSource music;
    public Light directionalLight;
    public Material skycursed;
    public GameObject light_cursed;
    public GameObject monster;
    public GameObject monsterbox;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;


    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject i;
    public GameObject j;

    public GameObject finalterntive;


    private void OnTriggerEnter(Collider col)

    {
        if (col.name == "First person player")
        {
            music.pitch = -0.2f;
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAA");
            directionalLight.color = Color.red;
            RenderSettings.skybox = skycursed;
            light_cursed.SetActive(true);
            monster.SetActive(false);
            monsterbox.SetActive(false);
            
            finalterntive.SetActive(true);
            a.SetActive(false);
            b.SetActive(false);
            c.SetActive(false);
            d.SetActive(false);
            e.SetActive(false);

            f.SetActive(true);
            g.SetActive(true);
            h.SetActive(true);
            i.SetActive(true);
            j.SetActive(true);

             
        }
        
    }
}
