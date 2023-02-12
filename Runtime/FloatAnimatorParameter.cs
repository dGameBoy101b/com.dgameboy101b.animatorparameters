using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Float Animator Parameter")]
	public class FloatAnimatorParameter : AnimatorParameter<float>
	{
		public override float Value 
		{
			get => this.Animator.GetFloat(this.ParameterName);
			set => this.Animator.SetFloat(this.ParameterName, value);
		}
	}
}
