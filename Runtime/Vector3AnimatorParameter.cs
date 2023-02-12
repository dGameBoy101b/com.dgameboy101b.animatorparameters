using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Vector3 Animator Parameter")]
	public class Vector3AnimatorParameter : AnimatorParameter<Vector3>
	{
		public string XName { get => this.ParameterName + ".x"; }

		public string YName { get => this.ParameterName + ".y"; }

		public string ZName { get => this.ParameterName + ".z"; }

		public override Vector3 Value 
		{
			get => new Vector3(
				this.Animator.GetFloat(this.XName),
				this.Animator.GetFloat(this.YName),
				this.Animator.GetFloat(this.ZName)
			);
			set
			{
				this.Animator.SetFloat(this.XName, value.x);
				this.Animator.SetFloat(this.YName, value.y);
				this.Animator.SetFloat(this.ZName, value.z);
			}
		}
	}
}
