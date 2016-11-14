using UnityEngine;
using System.Collections;

public class BallMotor : MonoBehaviour {
    public float moveSpeed = 5.0f;
    public float jumpHeight = 0.1f;


    public float terminalRotationSpeed = 25.0f;
    public Vector3 MoveVector { set; get; }
    private Rigidbody thisRigidbody;
    public VirtualJoystick joystick;
	// Use this for initialization
	void Start () {
        thisRigidbody = gameObject.GetComponent<Rigidbody>();
        thisRigidbody.maxAngularVelocity = terminalRotationSpeed;
      
	}
	
	// Update is called once per frame
	void Update () {
        MoveVector = PoolInput();
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            thisRigidbody.velocity = Vector3.zero;
            thisRigidbody.AddForce(MoveVector* 10, ForceMode.VelocityChange);
        }

	}
    public void Boost()
    {
        thisRigidbody.velocity = Vector3.zero;
        thisRigidbody.AddForce((MoveVector + Vector3.up * jumpHeight) * 10, ForceMode.VelocityChange);
    }
    private void Move ()
    {
        thisRigidbody.AddForce((MoveVector * moveSpeed));
    }
    private Vector3 PoolInput()
    {
        Vector3 dir = Vector3.zero;
        // dir.x = Input.GetAxis("Horizontal");
        // dir.z = Input.GetAxis("Vertical");
        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();
        if (dir.magnitude > 1)
            dir.Normalize();
        return dir;
    }
}
