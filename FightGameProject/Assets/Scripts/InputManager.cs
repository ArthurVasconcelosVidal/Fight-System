using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour{
    ActionControl actionControl;
    float movimentAxis;

    public float MovimentAxis { get { return movimentAxis; } }

    private void Awake(){
        //SetUp
        actionControl = new ActionControl();

        //GetMoviment
        actionControl.MainAction.Moviment.performed += ctx => {
            movimentAxis = ctx.ReadValue<float>();
        };
    }

    private void OnEnable(){
        actionControl.Enable();
    }

    private void OnDisable(){
        actionControl.Disable();
    }
}
