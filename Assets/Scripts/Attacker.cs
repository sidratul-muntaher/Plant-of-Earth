using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    public GameObject co2;
    public Transform trans;
    public List<AudioClip> audios;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void StartShooting()
    {
        AudioSource.PlayClipAtPoint(audios[Random.Range(0, audios.Count)], Camera.main.transform.position, .5f);
        Instantiate(co2, trans.position, Quaternion.identity);
    }
}
