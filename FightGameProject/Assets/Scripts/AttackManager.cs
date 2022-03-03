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
    [SerializeField] float comboAttackTime;
    [SerializeField] bool nextAttack; //Debug
    [SerializeField] bool teste = false;

    public void Attack(AttackType attackType) {
        if (!PlayerManager.instance.AnimatorManager.CurrentAttackAnimationEnded() || teste)
            return;
        else
            teste = true;

        switch (atkId){
            case AtkId.notAtk:
                atkId = AtkId.baseAtk;
                break;
            case AtkId.baseAtk:
                if (attackType == AttackType.normal)
                    atkId = AtkId.midAtk;
                else if(attackType == AttackType.strong)
                    atkId = AtkId.midAtkEsp;
                break;
            case AtkId.midAtk:
                atkId = AtkId.endAtk;
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

        if (nextAttack)
            PlayerManager.instance.AnimatorManager.ShortPunch((int)atkId);
        else {
            PlayerManager.instance.AnimatorManager.Punch((int)atkId);
        }
    }

    IEnumerator AttackComboTimer(){
        nextAttack = true;
        yield return new WaitForSeconds(comboAttackTime);
        nextAttack = false;
    }

    public void StartComboTimer() {
        StartCoroutine("AttackComboTimer");
    }

}
