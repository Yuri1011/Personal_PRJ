using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour {
    private float speed = 5.0f;
    private float destroyRange = -10.0f;
    Rigidbody obstacleRB;
    void Start() {
        obstacleRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        obstacleRB.AddForce(Vector3.forward * -speed);

        if(transform.position.z < destroyRange) {
            Destroy(gameObject);
        }
    }
}
