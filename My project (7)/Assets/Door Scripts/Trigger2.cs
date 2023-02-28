using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{
    public static bool _2Trigger = false;
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        _2Trigger = true;
        Debug.Log("Второй тригер вход");
    }
    public void OnTriggerExit(Collider other)
    {
        _2Trigger = false;
        Debug.Log("Второй тригер выход");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
