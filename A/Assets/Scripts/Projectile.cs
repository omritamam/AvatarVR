using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // 0 - init state, 1- waiting to be shot
    public enum Move{InMove,GoodMove, BadMove, Shoot};

    public Move state;
    public GameObject head;
    public Vector3 headPosInit = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        //insert animation
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (state==Move.GoodMove)
        {
            transform.position = new Vector3(transform.position.x, headPosInit.y - 0.3f, transform.position.z);
        }

        checkCollision();
    }
    
    public void SwitchMove(Move move)
    {
        state = move;
    }

    void checkCollision()
    {
        
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
