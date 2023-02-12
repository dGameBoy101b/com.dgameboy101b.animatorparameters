using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Integer Animator Parameter")]
	public class IntegerAnimatorParameter : AnimatorParameter<int>
	{
		public override int Value 
		{
			get => this.Animator.GetInteger(this.ParameterName);
			set => this.Animator.SetInteger(this.ParameterName, value);
		}
	}
}
