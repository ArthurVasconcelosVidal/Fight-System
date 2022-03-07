using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTriggerBehaviour : MonoBehaviour{

    void OnTriggerEnter(Collider other) {
        if (!PlayerManager.instance.AnimatorManager.CurrentAttackAnimationEnded()) {
            /*
            if (other.TryGetComponent<IAttackBehaviour>) {
                Continue Here
            }*/
        } 
    }

}
