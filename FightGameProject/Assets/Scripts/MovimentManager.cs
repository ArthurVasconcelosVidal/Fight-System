using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentManager : MonoBehaviour{
    [SerializeField] float velocity = 5;
    [SerializeField] float jumpForce = 5;

    // Update is called once per frame
    void FixedUpdate(){
        Moviment();
    }

    void Moviment() { 
        Vector3 finalPosition = transform.position + (transform.forward * PlayerManager.instance.InputManager.MovimentAxis) * velocity * Time.fixedDeltaTime;
        PlayerManager.instance.PlayerRigidbody.MovePosition(finalPosition);
    }

    public void Jump() {
        if (PlayerManager.instance.IsGrounded()) 
            PlayerManager.instance.PlayerRigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
}
