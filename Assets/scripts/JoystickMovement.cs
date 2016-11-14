using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class JoystickMovement : MonoBehaviour {

    private Vector3 initialPos;
    private Vector3 move;

	// Use this for initialization
	void Start () {
        initialPos = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (Input.GetMouseButtonDown(0))
        {
            initialPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            
        }

        if (Input.GetMouseButton(0))
        {
            move = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - initialPos).normalized;
            Debug.Log(move);
        }

        if (Input.GetMouseButtonUp(0))
        {
            move = Vector3.zero;
        }

        move.z = move.y;
        move.y = 0;
        */
	}

    void FixedUpdate()
    {
        transform.GetComponent<Rigidbody>().velocity = new Vector3(CrossPlatformInputManager.GetAxis("Horizontal"),
            0
            , CrossPlatformInputManager.GetAxis("Vertical")) * 5;
    }
}
