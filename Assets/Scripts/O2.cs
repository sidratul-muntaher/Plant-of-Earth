using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2 : MonoBehaviour
{
    [SerializeField] float speed = 5;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Random.Range(.1f, speed) * Time.deltaTime);
    }
}
