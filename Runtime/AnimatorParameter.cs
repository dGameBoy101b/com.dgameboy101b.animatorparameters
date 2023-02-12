using UnityEngine;

namespace dGameBoy101b.AnimatorParameters
{
	public abstract class AnimatorParameter<ValueType> : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("The animator this manipulates the parameters of")]
		public Animator Animator;

		[SerializeField]
		[Tooltip("The name of the parameter")]
		public string ParameterName;

		public abstract ValueType Value { get; set; }
	}
}
