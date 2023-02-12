using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	[AddComponentMenu("Animator Parameter/Integer Vector2 Animator Parameter")]
	public class IntegerVector2AnimatorParameter : AnimatorParameter<Vector2Int>
	{
		public string XName { get => this.ParameterName + ".x"; }

		public string YName { get => this.ParameterName + ".y"; }

		public override Vector2Int Value
		{
			get => new Vector2Int(
				this.Animator.GetInteger(this.XName),
				this.Animator.GetInteger(this.YName)
			);
			set
			{
				this.Animator.SetInteger(this.XName, value.x);
				this.Animator.SetInteger(this.YName, value.y);
			}
		}
	}
}
