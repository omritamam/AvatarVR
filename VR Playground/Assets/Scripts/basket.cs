#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    [SerializeField] GameObject deer;
    Animator deerAnimator;
    public fruitLifter fruitScript;
    public deer deerScript;

    bool flag = true;
    bool[] fruit = { false, false, false, false,false };

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (flag)
        {
            if (other.CompareTag("peanut"))
            {
                Debug.Log("change to false");
                fruitScript.isOn = false;
                flag = false;
            }
        }
        if (other.CompareTag("banana"))
        {
            fruit[0] = true; 
        }
        else if (other.CompareTag("banana"))
        {
            fruit[1] = true;
        }
        else if (other.CompareTag("banana"))
        {
            fruit[2] = true;
        }
        else if (other.CompareTag("banana"))
        {
            fruit[3] = true;
        }
        else if (other.CompareTag("banana"))
        {
            fruit[4] = true;
        }

    }
    // Update is called once per frame
    void Update()
    {
        bool completed_flag = true;
        foreach(bool fruitflag in fruit)
        {
            if(fruitflag == false)
            {
                completed_flag = false;
            }
        }

        if (completed_flag)
        {
            Debug.Log("change to false");
            deerScript.isOn = false;
        }
    }
}
#endif