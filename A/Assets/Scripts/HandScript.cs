using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using UnityEngine.TextCore;
using UnityEngine.XR.Interaction.Toolkit;
using Vector3 = UnityEngine.Vector3;

[SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
public class HandScript : MonoBehaviour
{
    [SerializeField] private GameObject rightHandObject;
    [SerializeField] private GameObject textObeject;
    [SerializeField] private GameObject textObject1;
    [SerializeField] private GameObject textObeject2;
    private Vector3[] up = new Vector3[10];
    
    
    
    public InputMaster myControls;

     void Awake()
    {
        for (int i = 0; i < 10; i++)
        {
            up[i] = new Vector3(0, i * 0.1f + 0.1f, 0);
        }
        myControls = new InputMaster();
        Debug.Log(up);
   
        myControls.player.record.performed += _ => record();
    }

     void record()
     { 
         StartCoroutine(recordCoroutine());
    }

     private IEnumerator recordCoroutine()
     {
         
         Queue<Vector3> movement = new Queue<Vector3>();
         Vector3 prime = new Vector3(0,0,0);
         while(myControls.player.record.ReadValue<float>()>0)
         {
             if (movement.Count == 0)
             {
                 prime = rightHandObject.transform.position;
             }
             
             Vector3 cur = rightHandObject.transform.position - prime;

             textObeject.GetComponent<TextMesh>().text = cur.ToString();
             if (movement.Count == 10)
             {
                 movement.Dequeue();
                 textObeject.GetComponent<TextMesh>().text ="10";;
             }
             movement.Enqueue(cur);
             yield return null;
         }
         
         textObject1.GetComponent<TextMesh>().text ="clearing";
         if (checkMove(movement))
         {
             
         }
         movement.Clear();
     }

     private bool checkMove(Queue<Vector3> movement)
     {
         if (movement.Count != 10)
         {
             textObeject2.GetComponent<TextMesh>().text ="movement too short in time " + movement.Count.ToString();
             return false;
         }
         textObeject2.GetComponent<TextMesh>().text ="movement magnitude is " + movement.Peek().magnitude.ToString();
         if (movement.Peek().magnitude < 1)
         {
             return false;
         }
         textObeject.GetComponent<TextMesh>().text =Vector3.Dot(up[9], movement.Peek().normalized).ToString();

         if (Vector3.Dot(up[9], movement.Peek().normalized) < 0.8)
         {
             
             return false;
         }
         textObject1.GetComponent<TextMesh>().text ="made it";
         return true;
     }
     

     void OnEnable()
    {
        myControls.Enable();
    }

     void OnDisable()
     {
         myControls.Disable();

     }





     //private InputDevice rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    Queue<Vector3> rightHand_positions = new Queue<Vector3>();
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            rightHand_positions.Enqueue(rightHandObject.transform.position);
            Debug.Log("added a position");
        
    }   
    
}
