using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static PlayerManager instance;

    [SerializeField] MovimentManager movimentManager;
    [SerializeField] InputManager inputManager;
    [SerializeField] Rigidbody playerRigidbody;
    [SerializeField] AnimatorManager animatorManager;
    [SerializeField] AttackManager attackManager;
    [SerializeField] LayerMask groundLayer;

    void Awake() {
        if (instance) Destroy(this);
        else instance = this;
    }

    public MovimentManager MovimentManager { get { return movimentManager; } }
    public InputManager InputManager { get { return inputManager; } }
    public Rigidbody PlayerRigidbody { get { return playerRigidbody; } }
    public AnimatorManager AnimatorManager { get { return animatorManager; } }
    public AttackManager AttackManager { get { return attackManager; } }

    public bool IsGrounded() {
        var colission = GetComponent<Collider>();
        float offset = 0.1f;
        if (Physics.Raycast(transform.position, -transform.up, colission.bounds.extents.y + offset, groundLayer)) return true;
        else return false;
    }
}
