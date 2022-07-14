using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public float Ver, Hor, Jump, RotHor, RotVer;
    bool isGround;
    public float speed, jumpSpeed = 30, Sensetivity = 5;
    Quaternion StartingRotating;

    void OnCollisionStay(Collision other){
        if(other.gameObject.tag == "ground"){
            isGround = true;
        }
    }

    void OnCollisionExit(Collision other){
        if(other.gameObject.tag == "ground"){
            isGround = false;
        }
    }

    public GameObject Camera;
    void Start() {
        StartingRotating = transform.rotation;
    }

    void Update(){
        
        RotHor += Input.GetAxis("Mouse X") * Sensetivity;
        RotVer += Input.GetAxis("Mouse Y") * Sensetivity;
        RotVer = Mathf.Clamp(RotVer, -60, 60);
        Quaternion RotY = Quaternion.AngleAxis(RotHor, Vector3.up);
        Quaternion RotX = Quaternion.AngleAxis(-RotVer, Vector3.right);
        Camera.transform.rotation = StartingRotating * transform.rotation * RotX;
        transform.rotation = StartingRotating * RotY;

        if(isGround){
            Ver = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            Hor = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
            Jump = Input.GetAxis("Jump") * Time.deltaTime * jumpSpeed;

            GetComponent<Rigidbody>().AddForce(transform.up * Jump, ForceMode.Impulse);
        }
        

        transform.Translate(new Vector3(Hor, 0, Ver));
    }
}
