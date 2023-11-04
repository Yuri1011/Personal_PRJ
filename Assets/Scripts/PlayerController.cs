using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody playerRB;
    private float speed = 10.0f;
    private float horizontalInput;
    private float verticalInput;
    Vector3 curreentPosition;
    private float minZ = -4.0f;
    private float maxZ = 4.0f;
    void Start() {
        playerRB = GetComponent<Rigidbody>();
    }
    void Update() {
        MovePlayer();
        LimitationMove();
    }

    void MovePlayer() {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 
        playerRB.AddForce(verticalInput * speed * Vector3.forward);
        playerRB.AddForce(horizontalInput * speed * Vector3.right);
    }

    void LimitationMove() {
        curreentPosition = transform.position;
        curreentPosition.z = Mathf.Clamp(curreentPosition.z, minZ, maxZ);
        transform.position = curreentPosition;
    }
}
