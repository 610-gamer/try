using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public float speed = 5f;
    public float force = 10f;
    public float H;
    public float V;
    public Rigidbody2D player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        H = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        V = Input.GetAxis("Jump") * speed * Time.deltaTime * 2;
        this.gameObject.transform.Translate(H, V, 0);
    }

    void FixedUpdate()
    {
        player.AddForce(new Vector3(0, -force, 0));
    }
}
