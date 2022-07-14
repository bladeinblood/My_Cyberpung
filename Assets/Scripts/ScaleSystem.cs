using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleSystem : MonoBehaviour
{
    void OnMouseDown () {
        transform.localScale = new Vector3 ( transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
    }
}
