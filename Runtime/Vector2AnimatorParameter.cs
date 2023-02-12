using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Vector2 Animator Parameter")]
	public class Vector2AnimatorParameter : AnimatorParameter<Vector2>
	{
		public override Vector2 Value
		{
			get => new Vector2(this.Animator.GetFloat(this.XName), this.Animator.GetFloat(this.YName));
			set
			{
				this.Animator.SetFloat(this.XName, value.x);
				this.Animator.SetFloat(this.YName, value.y);
			}
		}

		public string XName { get => this.ParameterName + ".x"; }

		public string YName { get => this.ParameterName + ".y"; }
	}
}
