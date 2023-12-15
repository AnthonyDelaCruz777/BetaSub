using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ZombieBeta : MonoBehaviour
{
    public List<GameObject> listofZombieHearts;
 
    void Start()
    {
        //foreach (GameObject heart in listofHearts)
        //COMMENTING A COMMENT WHILE COMMENTING
    }

    void Update()
    {
        GameObject lives = GameObject.FindGameObjectsWithTag("ZombieHearts")[0];
        if (Input.GetKeyDown(KeyCode.G))
        {
            Destroy(lives);
            Debug.Log("zombie dyingggggggg");
        }
    }
}