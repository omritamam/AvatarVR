using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject door;
    [SerializeField] private Animator doorAnimator;
    Animator deerAnimator;
    public bool isOn=false;
    void Start()
    {
        Debug.Log("started!");

        deerAnimator = this.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (!isOn)
        {
            if (other.CompareTag("apple"))
            {
                // deerAnimator.Play("happyDeer");
                Debug.Log("inside if");
                doorAnimator.Play("doorOpen2", 0, 0.0f);

            }
        }

        else
        {
            //deerAnimator.Play("sadDeer")
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
