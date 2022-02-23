using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour{
    [SerializeField] Animator playerAnimator;

	public Animator PlayerAnimator { get { return playerAnimator; } }

    public void WalkFoward(bool state) {
		if (state)
			playerAnimator.SetBool("Walk Forward", true);
		else
			playerAnimator.SetBool("Walk Forward", false);
	}

	public void WalkBackward(bool state) {
		if (state)
			playerAnimator.SetBool("Walk Backward", true);
		else
			playerAnimator.SetBool("Walk Backward", false);
	}

	public void WalkAnimation(float value) {
		Mathf.Clamp(value, -1,1);
		playerAnimator.SetBool("Walking", PlayerManager.instance.InputManager.MovimentAxisState);
		playerAnimator.SetFloat("WalkValue", value);
	}

	public void Punch(int punchId) {
		playerAnimator.SetInteger("Punch", punchId);
	}

	public void Damage() {
		playerAnimator.SetTrigger("Damage");
	}

	public bool CurrentAnimationEnded(int animationID) {
		Debug.Log(playerAnimator.GetCurrentAnimatorStateInfo(1).);
		if (false){
			var actualClipInfo = playerAnimator.GetCurrentAnimatorClipInfo(1);
			Debug.Log(actualClipInfo[0].clip.name);
			return true;
		}
		return false;
	}
}