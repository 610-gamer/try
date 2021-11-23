using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    CharactorController2D cc;
    public float speed = 5f;
    float move;
    bool jump;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharactorController2D>();
        Debug.Log("1");
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");
        move *= speed;
        jump = Input.GetButton("Jump");

        cc.Move(move, jump);
    }
    private void FixedUpdate()
    {
        cc.Move(move, jump);
    }
}