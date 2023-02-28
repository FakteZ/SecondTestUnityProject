using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    public Animator _animator;
    public bool isOpened = false;
    public bool isOpened2 = false;
    public bool _1Trigger = Trigger1._1Trigger;
    public bool _2Trigger = Trigger2._2Trigger;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void Open1()
    {
        _animator.SetBool("isOpened", isOpened);
        isOpened = !isOpened;
        Debug.Log("В первом колайдере выполнил скрипт");
    }
    public void Open2()
    {
        _animator.SetBool("isOpened2", isOpened2);
        isOpened2 = !isOpened2;
        Debug.Log("Во втором колайдере выполнил скрипт");
    }

    // Update is called once per frame
    void Update()
    {
        _1Trigger = Trigger1._1Trigger;
        _2Trigger = Trigger2._2Trigger;
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (_1Trigger)
            {
                Open1();
                Debug.Log("В первом колайдере нажал кнопку");
            }
            if (_2Trigger)
            {
                Open2();
                Debug.Log("Во втором колайдере нажал кнопку");
            }
            
        }
        
    }
}
