using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    private GameObject player;
    public Transform teleportPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Projectile") {
            CharacterController cc = player.GetComponent<CharacterController>();

            cc.enabled = false;
            player.transform.position = teleportPoint.position;
            cc.enabled = true;
        }
    }       
}
