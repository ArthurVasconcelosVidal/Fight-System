using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTriggerBehaviour : MonoBehaviour{

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy") && !PlayerManager.instance.AnimatorManager.CurrentAttackAnimationEnded()){
            IAttackBehaviour attackBehaviour;
            if (other.TryGetComponent(out attackBehaviour))
                attackBehaviour.AttackRecivedBehaviour();
        }
    }

}
