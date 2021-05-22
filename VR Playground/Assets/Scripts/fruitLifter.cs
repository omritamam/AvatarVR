using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitLifter : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] Rigidbody[] rigitbodys = new Rigidbody[10];
    public bool isOn=true;
    int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("fruits len is"+fruits.Length);
        int i = 0;
        foreach (GameObject fruit in fruits)
        {
           
           // rigitbodys[i] = (Rigidbody) fruit.GetComponent("Rigidbody");
            Debug.Log("added!");
            i++;
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
        foreach (Rigidbody rigidbody in rigitbodys)
        {
            if (isOn)
            {
                if (rigidbody.position.y < 0.3)
                {
                    if (i == 1)
                    {
                        i++;

                        rigidbody.position = new Vector3(-0.630f, 0.71f, 0.83f);
                    }
                    else if (i == 2)
                    {
                        i++;

                        rigidbody.position = new Vector3(-0.0f, 0.71f, 0.83f);
                    }
                    else if (i == 3)
                    {
                        i = 1;
                        rigidbody.position = new Vector3(0.430f, 0.71f, 0.83f);
                        Debug.Log("i is "+i);

                    }
                }
            }
        }
        

        
    }
}
