using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxLevel : MonoBehaviour
{
    Text oxText;
    public static float oxyzenL = 20;
    // Start is called before the first frame update
    void Start()
    {
        oxyzenL = 20;
        oxText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        oxText.text = "Oxyzen " + oxyzenL + " L";
    }
}
