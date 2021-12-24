using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Co2Level : MonoBehaviour
{
    Text co2Text;
    public static float co2L = 20;
    // Start is called before the first frame update
    void Start()
    {
        co2L = 10;
        co2Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        co2Text.text = "Carbon Di Oxide " + co2L + " L";
    }
}
