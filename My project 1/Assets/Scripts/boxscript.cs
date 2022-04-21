using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxscript : MonoBehaviour
{
    public Vector3 goUp;
    public float speed =2.0f;

    // Start is called before the first frame update
    void Start() //like a constructor
    {
    }

    // Update is called once per frame
    void Update()
    {
        //this is the game object that this script is attached to
        Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
        rb.velocity = goUp * speed;
    }
}

