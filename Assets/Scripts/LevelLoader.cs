using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public GameObject button;
    public GameObject text;
    public AudioClip audio;

    //private void Awake()
    //{
    //    if (FindObjectsOfType<LevelLoader>().Length > 1)
    //    {
    //        Destroy(gameObject);
    //    }
    //    else
    //    {
    //        DontDestroyOnLoad(gameObject);
    //    }
    //}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        StartCoroutine(StartGamePlay());
    }
    IEnumerator StartGamePlay()
    {
        button.SetActive(false);
        text.SetActive(true);
        AudioSource.PlayClipAtPoint(audio, Camera.main.transform.position, .8f);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }

   

    
}
