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
        Debug.Log("������ ������ ����");
    }
    public void OnTriggerExit(Collider other)
    {
        _2Trigger = false;
        Debug.Log("������ ������ �����");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
