using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public List<AudioClip> audios;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CarbonDO>() && this.GetComponent<TrantEgg>())
        {
            OxLevel.oxyzenL = OxLevel.oxyzenL + .4f;
        }
        else if(collision.GetComponent<CarbonDO>() && this.GetComponent<TrantFruit>())
        {
            OxLevel.oxyzenL = OxLevel.oxyzenL + .8f;
        }
        else if (collision.GetComponent<CarbonDO>() && this.GetComponent<PaperTree>())
        {
            OxLevel.oxyzenL = OxLevel.oxyzenL + .6f;
        }
        else if (collision.GetComponent<CarbonDO>() && this.GetComponent<TransGas>())
        {
            OxLevel.oxyzenL = OxLevel.oxyzenL + 1f;
        }
        AudioSource.PlayClipAtPoint(audios[Random.Range(0, audios.Count)], Camera.main.transform.position, .2f);
    }
}
