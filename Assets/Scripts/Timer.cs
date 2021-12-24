using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    Text timer;
    int x = 100;
    public static int timerS = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        timerS = 0;
        timer = GetComponent<Text>();
    }
    IEnumerator Start()
    {
        while (true)
        {
            StartCoroutine(Tim());
            yield return new WaitForSeconds(1);
        }
        
    }

    // Update is called once per frame
    IEnumerator Tim()
    {
        yield return new WaitForSeconds(1);
        if (timerS > 0)
        {
            timerS = timerS - 1;
        }
        
        timer.text = timerS.ToString();
    }
}
