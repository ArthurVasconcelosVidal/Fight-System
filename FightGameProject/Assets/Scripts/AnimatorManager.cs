using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour{
    [SerializeField] Animator playerAnimator;
	[SerializeField] PlayerAnimationEvents animationsEvents;

	public Animator PlayerAnimator { get { return playerAnimator; } }
    public PlayerAnimationEvents PlayerAnimationsEvents { get { return animationsEvents; } }

	public void WalkAnimation(float value) {
		Mathf.Clamp(value, -1,1);
		playerAnimator.SetBool("Walking", PlayerManager.instance.InputManager.MovimentAxisState);
		playerAnimator.SetFloat("WalkValue", value);
	}

	public void Punch(int punchId) {
		playerAnimator.SetInteger("Punch", punchId);
		playerAnimator.SetTrigger("AtkTrigger");
	}

	public void ShortPunch(int punchId) {
		playerAnimator.SetInteger("Punch", punchId);
		playerAnimator.SetTrigger("AtkTrigger");
		playerAnimator.SetTrigger("ShortcuttAtk");
	}

	public void Damage() { 
		playerAnimator.SetTrigger("Damage");
	}

	public bool CurrentAttackAnimationEnded() {
		if (playerAnimator.GetCurrentAnimatorClipInfo(1).Length > 0)
			return false;

		return true;
	}
}
