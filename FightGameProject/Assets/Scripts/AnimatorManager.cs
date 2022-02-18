using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour{
    [SerializeField] Animator playerAnimator;
	[SerializeField] string punch;

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

	public void Punch() {
		playerAnimator.SetTrigger(punch);
	}

}
