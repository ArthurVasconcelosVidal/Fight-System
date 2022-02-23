using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum attackId { 
    ataqueBase = 1,
    ataqueIntermedio = 2,
    ataqueConclusivo = 3,
    ataqueIntermedioEspecial = 4,
    ataqueConclusivoEspecial = 5
}

public class AttackManager : MonoBehaviour{
    attackId attackId;


    public void NormalAttack() {
        Debug.Log("Normal Attack");
    }

    public void StrongAttack() {
        Debug.Log("Strong Attack");
        PlayerManager.instance.AnimatorManager.CurrentAnimationEnded(0);
    }
}
