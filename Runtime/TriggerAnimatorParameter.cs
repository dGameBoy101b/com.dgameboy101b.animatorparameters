using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Trigger")]
	public class TriggerAnimatorParameter : AnimatorParameter<bool>
	{
		public override bool Value 
		{
			get => this.Animator.GetBool(this.ParameterName);
			set
			{
				if (value)
					this.Animator.SetTrigger(this.ParameterName);
				else
					this.Animator.ResetTrigger(this.ParameterName);
			}
		}
	}
}
