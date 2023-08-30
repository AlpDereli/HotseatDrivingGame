using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Control : MonoBehaviour
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
        inputTurn = Input.GetAxis("Horizontal2");
        inputSpeed = Input.GetAxis("Vertical2");
        transform.Translate(Vector3.forward * Time.deltaTime * speed* inputSpeed);
        transform.Rotate(Vector3.up, inputTurn*Time.deltaTime*turn);
    }
}
