using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // how fast the player moves



    void Update() {
        PlayerMovement();
    }

    void PlayerMovement(){
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 PlayerMovement = new Vector3(hor, 0f, ver) * speed * Time.deltaTime;
        transform.Translate(PlayerMovement, Space.Self);
    }
}
