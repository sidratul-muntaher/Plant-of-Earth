using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToStart : MonoBehaviour
{
    public void StartSC()
    {
        SceneManager.LoadScene(0);
    }
}
