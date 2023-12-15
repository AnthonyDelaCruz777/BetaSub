using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DetectCollisionsX : MonoBehaviour
{
    public ParticleSystem poofParticle;
    public bool dyingYet = false;
    
    void OnTriggerEnter(Collider other)
    { 
        //  poofParticle = GetComponent<ParticleSystem>();

       dyingYet = true;
       GameObject go = GameObject.FindGameObjectsWithTag("Hearts")[0];
       GameObject lives = GameObject.FindGameObjectsWithTag("ZombieHearts")[0];

        if(!poofParticle.isPlaying) {
            // poofParticle.gameObject.SetActive(true);
            poofParticle.Play();
        }

       Destroy(gameObject);
       Destroy(other.gameObject);
       Destroy(lives);
       Destroy(go);

       

       
    }


    

    // void Update(){
    //    if (dyingYet = true)
    //    {
    //     poofParticle.Play();
    //    }
    // }






    //    if(bk = GameObject.FindGameObjectWithTag("Big Knight"))
    //    {
        
    //     Destroy(go);
    //    }
    

    // void OnCollisionEnter(Collision collision)
    // {
    //     if(collision.gameObject.CompareTag("Skeleton"))
    //     {
    //         poofParticle.Play();
    //     }

    // }

    // void OnTriggerEnter(Collider other)
    // {
    //     Destroy(gameObject);
    //     Destroy(other.gameObject);

    //     Debug.Log("Zombie hit!");
    //         //TakeDamage(2);
    // }
}
