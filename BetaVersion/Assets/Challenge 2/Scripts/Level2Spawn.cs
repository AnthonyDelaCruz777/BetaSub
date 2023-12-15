using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Spawn : MonoBehaviour{
public GameObject[] ballPrefabs;

    public ParticleSystem poofParticle;
    private float spawnLimitXLeft = -53.1f;
    private float spawnLimitXRight = -53.1f;
    private float spawnPosY = 0;
    //private float spawnPosZ = -29;
    //private float spawnPosX = -53.1f;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;

    //public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    //public Button restartButton; 

    public List<GameObject> targetPrefabs;

    // private int score;
    // private float spawnRate = 1.5f;
    //public bool isGameActive;



    /*private float spaceBetweenSquares = 2.5f; 
    private float minValueX = -3.75f; //  x value of the center of the left-most square
    private float minValueY = -3.75f; //  y value of the center of the bottom-most square
    */
    // Start the game, remove title screen, reset score, and adjust spawnRate based on difficulty button clicked

    // Start is called before the first frame update

    /*public void StartGame(int difficulty)
    {
        spawnRate /= difficulty;
        isGameActive = true;
        StartCoroutine(Start());

        titleScreen.SetActive(false);
    }*/

    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        
          if(!poofParticle.isPlaying) {
            // poofParticle.gameObject.SetActive(true);
            poofParticle.Play();
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int index = Random.Range(0,ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, -29);
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[index].transform.rotation);
        //Instantiate(ballPrefabs, transform.position, ballPrefabs.transform.rotation);
    }

}
