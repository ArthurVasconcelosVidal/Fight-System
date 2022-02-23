using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentManager : MonoBehaviour{
    [SerializeField] float velocity = 5;
    [SerializeField] float jumpForce = 5;
    [SerializeField] Animator animator;

    // Update is called once per frame
    void FixedUpdate(){
        //Moviment();
    }

    void Moviment() {
        Vector3 finalPosition = transform.position + (transform.forward * PlayerManager.instance.InputManager.MovimentAxis) * velocity * Time.fixedDeltaTime;
        PlayerManager.instance.PlayerRigidbody.MovePosition(finalPosition);
    }

    void OnAnimatorMove(){
        PlayerManager.instance.transform.rotation = animator.rootRotation;

        //PlayerManager.instance.transform.position += animator.deltaPosition * velocity * Time.fixedDeltaTime;
        PlayerManager.instance.transform.position += Vector3.Scale(animator.deltaPosition, Vector3.forward) * velocity * Time.fixedDeltaTime;
        PlayerManager.instance.AnimatorManager.WalkAnimation(PlayerManager.instance.InputManager.MovimentAxis);
    }

    public void Jump() {
        if (PlayerManager.instance.IsGrounded()) 
            PlayerManager.instance.PlayerRigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }

}
