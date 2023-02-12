using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class BooleanAnimatorParameterTest : AnimatorParameterTest
	{
		private BooleanAnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<BooleanAnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.ParameterName, AnimatorControllerParameterType.Bool);
		}

		[Test]
		public void ReadsBoolean()
		{
			Assert.AreEqual(this.animator.GetBool(this.parameter.ParameterName), this.parameter.Value);
		}

		[Test]
		public void WritesBoolean()
		{
			const bool VALUE = true;
			this.parameter.Value = VALUE;
			Assert.AreEqual(VALUE, this.animator.GetBool(this.parameter.ParameterName));
		}
	}
}
