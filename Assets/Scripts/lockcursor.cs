using UnityEngine;

public class lockcursor : MonoBehaviour
{
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

}
