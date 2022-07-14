using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSystem : MonoBehaviour
{
    public GameObject obj;
    public float range = 5f, moveSpeed = 10f, turnSpeed = 5f;

    void Update () {

        if ( Input.GetKey ( KeyCode.Y ) ) {
            obj.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if ( Input.GetKey ( KeyCode.H ) ) {
            obj.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if ( Input.GetKey ( KeyCode.G ) ) {
            obj.transform.Rotate(Vector3.up * -turnSpeed * Time.deltaTime);
        }
        if ( Input.GetKey ( KeyCode.J ) ) {
            obj.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }
    }
}
