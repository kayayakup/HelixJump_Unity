using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{

    float horizontalArroyKey;
    float spinSpeed = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalArroyKey = Input.GetAxis("Horizontal") * spinSpeed * Time.deltaTime;
        transform.Rotate(0, horizontalArroyKey, 0);
    }
}
