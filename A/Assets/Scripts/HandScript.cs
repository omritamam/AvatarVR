using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR.Interaction.Toolkit;

[SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
public class HandScript : MonoBehaviour
{
    [SerializeField] private GameObject rightHandObject;
    [SerializeField] private GameObject textObeject;
    [SerializeField] private GameObject textObeject2;

    public InputMaster myControls;

     void Awake()
    {
        myControls = new InputMaster();
        myControls.player.record.performed += _ => record();
    }

     void record()
    {
        textObeject2.GetComponent<TextMesh>().text ="inside record";
        textObeject.GetComponent<TextMesh>().text = rightHandObject.transform.position.ToString();
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
