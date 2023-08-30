using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 20.0f;
    private float turn = 25.0f;
    private float inputTurn;
    private float inputSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputTurn = Input.GetAxis("Horizontal");
        inputSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed* inputSpeed);
        transform.Rotate(Vector3.up, inputTurn*Time.deltaTime*turn);
    }
}
