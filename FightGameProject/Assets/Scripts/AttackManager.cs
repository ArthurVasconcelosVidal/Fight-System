using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum AtkId {
    notAtk = 0,
    baseAtk,
    midAtk,
    endAtk,
    midAtkEsp,
    endAtkEsp
}

public enum AttackType{
    normal = 1,
    strong
}

public class AttackManager : MonoBehaviour{
    AtkId atkId = AtkId.notAtk;
    [SerializeField] bool canAttackAgain = true;

    public void CanAttackAgain() => canAttackAgain = true;

    public void Attack(AttackType attackType) {
        if (!canAttackAgain)
            return;

        canAttackAgain = false;

        switch (atkId){
            case AtkId.notAtk:
                atkId = AtkId.baseAtk;
                break;
            case AtkId.baseAtk:
                atkId = AtkId.midAtk;
                break;
            case AtkId.midAtk:
                if (attackType == AttackType.normal)
                    atkId = AtkId.endAtk;
                else if (attackType == AttackType.strong)
                    atkId = AtkId.midAtkEsp;
                break;
            case AtkId.endAtk:
                atkId = AtkId.baseAtk;
                break;
            case AtkId.midAtkEsp:
                if (attackType == AttackType.normal)
                    atkId = AtkId.endAtk;
                else if(attackType == AttackType.strong)
                    atkId = AtkId.endAtkEsp;
                break;
            case AtkId.endAtkEsp:
                atkId = AtkId.baseAtk;
                break;
            default:
                break;
        }

        PlayerManager.instance.AnimatorManager.Punch((int)atkId);
    }
}
