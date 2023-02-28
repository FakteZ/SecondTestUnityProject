using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenScript : MonoBehaviour
{
    public Animator _animator;
    public bool isOpened = false;
    public bool isOpened2 = false;
    public bool reason = false;
    public bool _1Trigger = Trigger1._1Trigger;
    public bool _2Trigger = Trigger2._2Trigger;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    public void Open1()
    {
        reason = isOpened2 | isOpened;

        if (reason)
        {
            isOpened2 = false;
            isOpened = false;
            _animator.SetBool("isOpened", isOpened);
            _animator.SetBool("isOpened2", isOpened2);
            
        }
        else
        {
            isOpened = !isOpened;
            _animator.SetBool("isOpened", isOpened);

            Debug.Log("1 сторона нет");
        } 
    }
    public void Open2()
    {
        reason = isOpened2 | isOpened;
        if (reason)
        {
            isOpened2 = false;
            isOpened = false;
            _animator.SetBool("isOpened", isOpened);
            _animator.SetBool("isOpened2", isOpened2);
            
        }
        else
        {
            isOpened2 = true;
            _animator.SetBool("isOpened2", isOpened2);
            
        }
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
                
            }
            if (_2Trigger)
            {
                Open2();
               
            }
            
        }
        
    }
}
