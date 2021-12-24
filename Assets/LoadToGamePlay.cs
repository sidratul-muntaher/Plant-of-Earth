using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadToGamePlay : MonoBehaviour
{
    public void GameOver()
    {
        StartCoroutine(GameOverScreen());

    }

    IEnumerator GameOverScreen()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(2);
    }
}
