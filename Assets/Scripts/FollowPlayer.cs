using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0,7,-9);
    private Vector3 offset2 = new Vector3 (0,4,3.5f);
    private Vector3 remember = new Vector3(0,7,-9);
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            offset1 = offset2;
            if (i%2==0)
            {
                offset1 = remember;
            }
            i++;
        }
        transform.rotation = player.transform.rotation;
        transform.position = player.transform.position + offset1;
    }
}
