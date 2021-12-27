using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<CarbonDO>())
        {
            Co2Level.co2L = Co2Level.co2L + 1.5f;
        }
    }
}
