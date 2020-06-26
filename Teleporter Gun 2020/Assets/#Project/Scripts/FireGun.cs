using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject projectile;
    public Transform spawnPoint;

    private void Fire() {
        Vector3 position = spawnPoint.position;
        Quaternion rotation = spawnPoint.rotation;

        Instantiate(projectile, position, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Fire();
        }
    }
}
