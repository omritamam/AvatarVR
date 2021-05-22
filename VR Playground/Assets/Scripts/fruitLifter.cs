using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitLifter : MonoBehaviour
{
    [SerializeField] GameObject[] fruits;
    [SerializeField] Rigidbody[] rigitbodys;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("fruits len is"+fruits.Length);
        foreach (GameObject fruit in fruits)
        {
            rigitbodys[rigitbodys.Length - 1] = (Rigidbody) fruit.GetComponent("Rigidbody");
            Debug.Log("added!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        foreach (Rigidbody rigidbody in rigitbodys)
        {
            if (rigidbody.position.y < 0.3)
            {
                Debug.Log("goona lift");
                rigidbody.position = new Vector3(-0.630f, 0.71f, 0.83f);
            }
        }
        

        
    }
}
