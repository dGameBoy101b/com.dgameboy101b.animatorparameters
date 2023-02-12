using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Vector4 Animator Parameter")]
	public class Vector4AnimatorParameter : AnimatorParameter<Vector4>
	{
		public string WName { get => this.ParameterName + ".w"; }

		public string XName { get => this.ParameterName + ".x"; }

		public string YName { get => this.ParameterName + ".y"; }

		public string ZName { get => this.ParameterName + ".z"; }

		public override Vector4 Value
		{
			get => new Vector4(
				this.Animator.GetFloat(this.XName),
				this.Animator.GetFloat(this.YName),
				this.Animator.GetFloat(this.ZName),
				this.Animator.GetFloat(this.WName)
			);
			set
			{
				this.Animator.SetFloat(this.WName, value.w);
				this.Animator.SetFloat(this.XName, value.x);
				this.Animator.SetFloat(this.YName, value.y);
				this.Animator.SetFloat(this.ZName, value.z);
			}
		}
	}
}
