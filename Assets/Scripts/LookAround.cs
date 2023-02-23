using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LookAround : MonoBehaviour
{

    public float sensitivity = 15f;

  
    void Awake()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float Pitch = Input.GetAxis("Pitch");
        float roll = Input.GetAxis("Roll");
    }

}
