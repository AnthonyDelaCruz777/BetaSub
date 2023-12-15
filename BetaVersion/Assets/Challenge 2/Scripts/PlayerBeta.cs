using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEditor;
using System.Linq;

using UnityEngine.SceneManagement;

public class PlayerBeta : MonoBehaviour
{
    public List<GameObject> listofHearts;
     
    
    void Start()
    {
        //listofHearts = listofHearts.OrderBy(x => x.transform.position.y).ToList();
        //listofHearts.Sort((o, o1) => o.transform.position.y.CompareTo(o1.transform.position.y));
        //foreach (GameObject heart in listofHearts)
    }
    

    void Update()
    {
    
        GameObject go = GameObject.FindGameObjectsWithTag("Hearts")[0];
        if (Input.GetKeyDown(KeyCode.P))
            {
            //Destroy(go);
            Debug.Log("Taking damage");
        }

        if (Input.GetKeyDown(KeyCode.Z))
       {
            Die();
       }

       else if (Input.GetKeyDown(KeyCode.X))
       {
            Win();
       } 

        // if (go = 0)
        // {
        //     Die();
        // }
    }

    void Die()
    {
        SceneManager.LoadScene("GameOverScreen");
    }

    void Win()
    {
        SceneManager.LoadScene("WinOverScreen");
    }

    // void Die()
    // {
    //         SceneManager.LoadScene("GameOverScreen");  
    // }



    // private void OnTriggerEnter(Collider other)
    // {
    //     Destroy(gameObject);
    //     Destroy(other.gameObject);

    //     Debug.Log("Zombie hit!");
    //         //TakeDamage(2);
    // }

    

}