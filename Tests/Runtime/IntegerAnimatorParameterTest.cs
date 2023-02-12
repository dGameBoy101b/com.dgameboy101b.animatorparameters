using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class IntegerAnimatorParameterTest : AnimatorParameterTest
	{
		private IntegerAnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<IntegerAnimatorParameter>();
			this.parameter.Animator = this.animator;
			this.parameter.ParameterName = "Test Parameter";
			this.AddParameter(this.parameter.ParameterName, AnimatorControllerParameterType.Int);
		}

		[Test]
		public void ReadsInteger()
		{
			Assert.AreEqual(this.animator.GetInteger(this.parameter.ParameterName), this.parameter.Value);
		}

		[Test]
		public void WritesInteger()
		{
			const int VALUE = 34;
			this.parameter.Value = VALUE;
			Assert.AreEqual(VALUE, this.animator.GetInteger(this.parameter.ParameterName));
		}
	}
}
