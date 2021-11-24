using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dog_movement: MonoBehaviour
{

    public float speed = 5f;
    public float H;
    public float V;
    public Rigidbody2D dog;

    void Start()
    {
        dog = GetComponent<Rigidbody2D>();
        //this.gameObject.transform.Translate(a.position);
    }

    void Update()
    {
        H = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        V = Input.GetAxis("Jump") * speed * Time.deltaTime * 2;
        this.gameObject.transform.Translate(-H,V, 0);
    }

    void FixedUpdate()
    {
            dog.AddForce(new Vector3(0, 20f, 0));
    }

}

