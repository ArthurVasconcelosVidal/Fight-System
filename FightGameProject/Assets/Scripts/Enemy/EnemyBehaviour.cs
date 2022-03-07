using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour, IAttackBehaviour{
    [SerializeField] Material damageMaterial, normalMaterial;
    [SerializeField] float timeAfterAtackBehaviour;

    public void AttackRecivedBehaviour(){
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = damageMaterial;
        Invoke("AfterAattack", timeAfterAtackBehaviour);
    }

    void AfterAattack(){
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = normalMaterial;
    }

}
