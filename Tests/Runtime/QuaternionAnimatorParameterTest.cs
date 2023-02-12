using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class QuaternionAnimatorParameterTest : AnimatorParameterTest
	{
		private QuaternionAnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<QuaternionAnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.WName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.XName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.YName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.ZName, AnimatorControllerParameterType.Float);
		}

		[Test]
		public void ReadsQuaternions()
		{
			const float W_VALUE = 0.23f;
			const float X_VALUE = -0.32f;
			const float Y_VALUE = 0.382f;
			const float Z_VALUE = 0.93f;
			this.animator.SetFloat(this.parameter.WName, W_VALUE);
			this.animator.SetFloat(this.parameter.XName, X_VALUE);
			this.animator.SetFloat(this.parameter.YName, Y_VALUE);
			this.animator.SetFloat(this.parameter.ZName, Z_VALUE);
			Assert.AreEqual(new Quaternion(X_VALUE, Y_VALUE, Z_VALUE, W_VALUE), this.parameter.Value);
		}

		[Test]
		public void WritesQuaternions()
		{
			const float W_VALUE = 0.23f;
			const float X_VALUE = -0.32f;
			const float Y_VALUE = 0.382f;
			const float Z_VALUE = 0.93f;
			this.parameter.Value = new Quaternion(X_VALUE, Y_VALUE, Z_VALUE, W_VALUE);
			Assert.AreEqual(W_VALUE, this.animator.GetFloat(this.parameter.WName));
			Assert.AreEqual(X_VALUE, this.animator.GetFloat(this.parameter.XName));
			Assert.AreEqual(Y_VALUE, this.animator.GetFloat(this.parameter.YName));
			Assert.AreEqual(Z_VALUE, this.animator.GetFloat(this.parameter.ZName));
		}
	}
}
