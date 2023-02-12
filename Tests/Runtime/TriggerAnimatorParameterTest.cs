using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class TriggerAnimatorParameterTest : AnimatorParameterTest
	{
		private TriggerAnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<TriggerAnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.ParameterName, AnimatorControllerParameterType.Trigger);
		}

		[Test]
		public void ReadsSetTrigger()
		{
			this.animator.SetTrigger(this.parameter.ParameterName);
			Assert.IsTrue(this.parameter.Value);
		}

		[Test]
		public void ReadsUnsetTrigger()
		{
			this.animator.ResetTrigger(this.parameter.ParameterName);
			Assert.IsFalse(this.parameter.Value);
		}

		[Test]
		public void SetsTrigger()
		{
			this.parameter.Value = true;
			Assert.IsTrue(this.animator.GetBool(this.parameter.ParameterName));
		}

		[Test]
		public void ResetsTrigger()
		{
			this.parameter.Value = false;
			Assert.IsFalse(this.animator.GetBool(this.parameter.ParameterName));
		}
	}
}
