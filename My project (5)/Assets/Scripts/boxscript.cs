using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxscript : MonoBehaviour
{
    Vector3 goUp, goDown, goLeft, goRight, goJump;
    public float speed = 2.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        goUp = new Vector3(0f, 0f, 1f);
        goDown = new Vector3(0f, 0f, -3f);
        goLeft = new Vector3(-1f, 0f, 0f);
        goRight = new Vector3(1f, 0f, 0f);
        goJump = new Vector3(0f, 1f, 0f);
    }
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            print("up key was pressed");
            rb.velocity = goUp * speed;
        }
        else if (Input.GetKeyDown("down"))
        {
            print("down key was pressed");
            rb.velocity = goDown * speed;
        }
        else if (Input.GetKeyDown("left"))
        {
            print("left key was pressed");
            rb.velocity = goLeft * speed;
        }
        else if (Input.GetKeyDown("right"))
        {
            print("right key was pressed");
            rb.velocity = goRight * speed;
        }
        else if (Input.GetKeyDown("space"))
        {
            rb.velocity = goJump * speed;
        }
    }
        
    }