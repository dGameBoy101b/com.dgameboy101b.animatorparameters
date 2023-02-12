using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Color Animator Parameter")]
	public class ColorAnimatorParameter : AnimatorParameter<Color>
	{
		public string RedName { get => this.ParameterName + ".red"; }

		public string GreenName { get => this.ParameterName + ".green"; }

		public string BlueName { get => this.ParameterName + ".blue"; }

		public string AlphaName { get => this.ParameterName + ".alpha"; }

		public override Color Value 
		{
			get => new Color(
				this.Animator.GetFloat(this.RedName),
				this.Animator.GetFloat(this.GreenName),
				this.Animator.GetFloat(this.BlueName),
				this.Animator.GetFloat(this.AlphaName)
			);
			set
			{
				this.Animator.SetFloat(this.RedName, value.r);
				this.Animator.SetFloat(this.GreenName, value.g);
				this.Animator.SetFloat(this.BlueName, value.b);
				this.Animator.SetFloat(this.AlphaName, value.a);
			}
		}
	}
}
