using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static PlayerManager instance;

    [SerializeField] MovimentManager movimentManager;
    [SerializeField] InputManager inputManager;

    void Awake() {
        if (instance) Destroy(this);
        else instance = this;
    }

    public MovimentManager MovimentManager { get { return movimentManager; } }
    public InputManager InputManager { get { return inputManager; } }

}
