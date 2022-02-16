using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour{
    ActionControl actionControl;
    float movimentAxis;
    bool movimentAxisState;

    public float MovimentAxis { get { return movimentAxis; } }
    public bool MovimentAxisState { get { return movimentAxisState; } }

    //public delegate void SouthButtonAction();
    //public SouthButtonAction southButtonAction;

    private void Awake(){
        //SetUp
        actionControl = new ActionControl();

        //GetMoviment
        actionControl.MainAction.Moviment.performed += ctx => {
            movimentAxis = ctx.ReadValue<float>();
        };

        actionControl.MainAction.Moviment.started += ctx =>{
            movimentAxisState = true;
        };

        actionControl.MainAction.Moviment.canceled += ctx => {
            movimentAxisState = false;
            movimentAxis = 0;
        };
        
        //SouthButton
        actionControl.MainAction.SouthButton.performed += ctx =>{
            PlayerManager.instance.MovimentManager.Jump();
            //if (southButtonAction != null) southButtonAction();
        };
    }

    private void OnEnable(){
        actionControl.Enable();
    }

    private void OnDisable(){
        actionControl.Disable();
    }
}
