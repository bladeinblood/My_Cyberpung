using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public ParticleSystem muzzleflash;

    public Camera fpsCam;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update () {
        if(Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) {
            Debug.Log(hit.transform.name);

            TargetScript target = hit.transform.GetComponent<TargetScript>();
            if(target != null) {
                target.TakeDamage(damage);
            }
        }
        muzzleflash.Play();
    }
}