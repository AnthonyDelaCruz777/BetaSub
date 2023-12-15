using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{

    //GameObjects
    public GameObject[] dogPrefab;
    public GameObject[] spearPrefab;
    public GameObject[] strongKnightPrefab;

    // //Money
    // public static int coinAmount;
    // /*          public static int coinAmount;         */
    // public int costOne = 10;
    // public int costTwo = 15;
    // public int costThree = 25;

    //SpawnPoints
    private float spawnLimitXRight = 59;
    private float spawnLimitXAgain = 59;
    private float spawnPosY = 0; 
    float cooldownOne = 1.5f;
    float cooldownTwo = 2.4f;
    float cooldownThree = 2.85f;
    private bool isCooldownOne = false;
    private bool isCooldownTwo = false;
    private bool isCooldownThree = false;

    

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && !isCooldownOne)
        {
                    Debug.Log("Purcased Knight!");
            StartCoroutine(CooldownFirst());
            SpawnerKnight();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)&& !isCooldownTwo)
        {
                    Debug.Log("Purcased Spear Knight!");
            StartCoroutine(CooldownSecond());
            SpawnerSpear();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)&& !isCooldownThree)
        {
                    Debug.Log("Purcased Strong Knight!");
            StartCoroutine(CooldownThird());
            SpawnerSrong();
        }
    }


    private IEnumerator CooldownFirst()
    {
        isCooldownOne = true;
        yield return new WaitForSeconds(cooldownOne);
        isCooldownOne = false;
    }
    private IEnumerator CooldownSecond()
    {
        isCooldownTwo = true;
        yield return new WaitForSeconds(cooldownTwo);
        isCooldownTwo = false;
    }
    private IEnumerator CooldownThird()
    {
        isCooldownThree = true;
        yield return new WaitForSeconds(cooldownThree);
        isCooldownThree = false;
    }

    // Update is called once per frame
    private void SpawnerKnight()
    {
        int index = Random.Range(0,dogPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXRight,spawnLimitXAgain), spawnPosY, -29);
        Instantiate(dogPrefab[index], transform.position, dogPrefab[index].transform.rotation);        
    }

    private void SpawnerSpear()
    {
        int index = Random.Range(0,spearPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXRight,spawnLimitXAgain), spawnPosY, -29);
        Instantiate(spearPrefab[index], transform.position, spearPrefab[index].transform.rotation);
    }

    private void SpawnerSrong()
    {
        int index = Random.Range(0,strongKnightPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXRight,spawnLimitXAgain), spawnPosY, -29);
        Instantiate(strongKnightPrefab[index], transform.position, strongKnightPrefab[index].transform.rotation);

    }
}
