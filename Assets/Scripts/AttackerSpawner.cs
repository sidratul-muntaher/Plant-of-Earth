using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    public GameObject gameO;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return StartCoroutine(SpwmEnemy());
        }
    }

    IEnumerator SpwmEnemy()
    {
        yield return new WaitForSeconds(Random.Range(5f, 10f));
       var enemy =  Instantiate(gameO, transform.position, Quaternion.identity);

        enemy.transform.parent = transform;
        Destroy(enemy, 4f);

    }
   
}
