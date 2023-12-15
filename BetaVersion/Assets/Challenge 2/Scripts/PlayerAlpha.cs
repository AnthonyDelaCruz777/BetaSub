using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAlpha : MonoBehaviour
{
    public List<GameObject> listofHearts;
    // static int number = listofHearts.Count;
    // GameObject lastItem = listofHearts[number - 1];
    // GameObject go;
    
 
    void Start()
    {
    }

    void Update()
    {
    
        GameObject go = GameObject.FindGameObjectsWithTag("Hearts")[0];
        if (Input.GetKeyDown(KeyCode.P))
        {
            Destroy(go);
            Debug.Log("Taking damage");
        }
    
        // if(lastItem)
        // {
        //     Destroy(gameObject);
        // }

    // void OnTriggerEnter(Collider other)
    // {
    //     Destroy(go);
    //     Debug.Log("Hearts down!");   
    // }

        
    
    }
    // void OnTriggerEnter(Collider other)
    // {
    //     //Destroy(go);
    //     Debug.Log("Hearts down!");    
    // }
    
  

}