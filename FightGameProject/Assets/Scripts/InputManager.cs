using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour{
    ActionControl actionControl;
    float movimentAxis;

    public float MovimentAxis { get { return movimentAxis; } }

    //public delegate void SouthButtonAction();
    //public SouthButtonAction southButtonAction;

    private void Awake(){
        //SetUp
        actionControl = new ActionControl();

        //GetMoviment
        actionControl.MainAction.Moviment.performed += ctx => {
            movimentAxis = ctx.ReadValue<float>();
        };

        actionControl.MainAction.Moviment.canceled += ctx => {
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
