using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Integer Vector3")]
	public class IntegerVector3AnimatorParameter : AnimatorParameter<Vector3Int>
	{
		public string XName { get => this.ParameterName + ".x"; }

		public string YName { get => this.ParameterName + ".y"; }

		public string ZName { get => this.ParameterName + ".z"; }

		public override Vector3Int Value 
		{
			get => new Vector3Int(
				this.Animator.GetInteger(this.XName),
				this.Animator.GetInteger(this.YName),
				this.Animator.GetInteger(this.ZName)
			);
			set
			{
				this.Animator.SetInteger(this.XName, value.x);
				this.Animator.SetInteger(this.YName, value.y);
				this.Animator.SetInteger(this.ZName, value.z);
			}
		}
	}
}
