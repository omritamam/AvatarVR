using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using InputDevice = UnityEngine.XR.InputDevice;

public class textScript : MonoBehaviour
{
       [SerializeField] private GameObject text_object0;
       [SerializeField] private GameObject text_object1;
       [SerializeField] private GameObject text_object2;
   
       // Start is called before the first frame update
       void Start()
       {
           var gameControllers = new List<InputDevice>(3);
           InputDevices.GetDevices(gameControllers);
           
           TextMesh text0 =  text_object0.GetComponent<TextMesh>();
           TextMesh text1 =  text_object1.GetComponent<TextMesh>();
           TextMesh text2 =  text_object2.GetComponent<TextMesh>();
   
           //text0.text ="0 "+ gameControllers[0].name;
           //text1.text = "1 " + gameControllers[1].name;
           //text2.text = " 2 "+ gameControllers[2].name;
   
   
   
       }
    // Update is called once per frame
    void Update()
    {
        
    }
}
