using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool _1Trigger = false;
    public void OnTriggerEnter(Collider other)
    {
        _1Trigger = true;
        Debug.Log("Первый тригер вход");
    }
    public void OnTriggerExit(Collider other)
    {
        _1Trigger = false;
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
