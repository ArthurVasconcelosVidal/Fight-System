using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum AtkId {
    notAtk = 0,
    baseAtk = 1,
    midAtk = 2,
    endAtk = 3,
    midAtkEsp = 4,
    endAtkEsp = 5
}

public class AttackManager : MonoBehaviour{
    AtkId atkId = AtkId.notAtk;

    public void NormalAttack(){
        if (!PlayerManager.instance.AnimatorManager.CurrentAttackAnimationEnded())
            return;

        switch (atkId){
            case AtkId.notAtk:
                atkId = AtkId.baseAtk;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                break;
            case AtkId.baseAtk:
                atkId = AtkId.midAtk;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                break;
            case AtkId.midAtk:
                atkId = AtkId.endAtk;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                atkId = AtkId.notAtk;
                break;
            case AtkId.endAtk:
                //Null
                break;
            case AtkId.midAtkEsp:
                atkId = AtkId.endAtk;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                atkId = AtkId.notAtk;
                break;
            case AtkId.endAtkEsp:
                //null
                break;
            default:
                //null
                break;
        }
        Debug.Log("Normal Attack");
    }

    public void StrongAttack(){
        if (!PlayerManager.instance.AnimatorManager.CurrentAttackAnimationEnded())
            return;

        switch (atkId){
            case AtkId.notAtk:
                atkId = AtkId.baseAtk;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                break;
            case AtkId.baseAtk:
                atkId = AtkId.midAtk;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                break;
            case AtkId.midAtk:
                atkId = AtkId.midAtkEsp;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                break;
            case AtkId.endAtk:
                //Null
                break;
            case AtkId.midAtkEsp:
                atkId = AtkId.endAtkEsp;
                PlayerManager.instance.AnimatorManager.Punch((int)atkId);
                atkId = AtkId.notAtk;
                break;
            case AtkId.endAtkEsp:
                //Null
                break;
            default:
                //Null
                break;
        }
        Debug.Log("Strong Attack");
        
    }


}
