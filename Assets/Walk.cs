using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {

    [SerializeField]
    float Speed = 1.0f;
    [SerializeField]
    float LeftWall = -4.0f;
    [SerializeField]
    float RightWall = +4.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.left * (- Input.mousePosition.x /25+6);

        if(transform.position.x < LeftWall)
        {
            transform.position = Vector3.right * LeftWall;
        }

    }

}
