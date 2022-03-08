using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour {

    void NextComboAttack() { 
        PlayerManager.instance.AttackManager.CanAttackAgain();
        PlayerManager.instance.AttackManager.StartResetTime();
    }
}
