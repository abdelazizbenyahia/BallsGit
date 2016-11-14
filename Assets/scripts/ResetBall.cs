using UnityEngine;
using System.Collections;

public class ResetBall : MonoBehaviour {
    private Vector3 pos;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        pos = transform.position;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < -5)
        { 
            transform.position = pos;
            rb.velocity = Vector3.zero;
        }
    }
}
