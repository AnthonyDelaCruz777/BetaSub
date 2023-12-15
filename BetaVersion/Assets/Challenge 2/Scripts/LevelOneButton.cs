using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelOneButton : MonoBehaviour
{

    public int level;
    public AudioSource soundEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OpenScene(){
        SceneManager.LoadScene("Level " + level.ToString());
    }
    //sound effect plays when button is clicked
    public void playSound()
    {
        soundEffect.Play();
    }


}
