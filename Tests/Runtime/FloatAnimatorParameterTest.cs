using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class FloatAnimatorParameterTest : AnimatorParameterTest
	{
		private FloatAnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<FloatAnimatorParameter>();
			this.parameter.Animator = this.animator;
			this.parameter.ParameterName = "Test Parameter";
			this.AddParameter(this.parameter.ParameterName, AnimatorControllerParameterType.Float);
		}

		[Test]
		public void ReadFloat()
		{
			Assert.AreEqual(this.animator.GetFloat(this.parameter.ParameterName), this.parameter.Value);
		}

		[Test]
		public void WriteFloat()
		{
			const float VALUE = 12.34f;
			this.parameter.Value = VALUE;
			Assert.AreEqual(VALUE, this.animator.GetFloat(this.parameter.ParameterName));
		}
	}
}
