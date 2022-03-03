using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour{

    void NextComboAttack(){
        Debug.Log("Passou por aqui");
        PlayerManager.instance.AttackManager.StartComboTimer();
    }
}
