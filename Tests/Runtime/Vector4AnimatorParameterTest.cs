using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class Vector4AnimatorParameterTest : AnimatorParameterTest
	{
		private Vector4AnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<Vector4AnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.WName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.XName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.YName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.ZName, AnimatorControllerParameterType.Float);
		}

		[Test]
		public void ReadsVector4s()
		{
			const float W_VALUE = 89.2f;
			const float X_VALUE = -34.4f;
			const float Y_VALUE = -499.002f;
			const float Z_VALUE = 23.81f;
			this.animator.SetFloat(this.parameter.WName, W_VALUE);
			this.animator.SetFloat(this.parameter.XName, X_VALUE);
			this.animator.SetFloat(this.parameter.YName, Y_VALUE);
			this.animator.SetFloat(this.parameter.ZName, Z_VALUE);
			Assert.AreEqual(new Vector4(X_VALUE, Y_VALUE, Z_VALUE, W_VALUE), this.parameter.Value);
		}

		[Test]
		public void WritesVector4s()
		{
			const float W_VALUE = 89.2f;
			const float X_VALUE = -34.4f;
			const float Y_VALUE = -499.002f;
			const float Z_VALUE = 23.81f;
			this.parameter.Value = new Vector4(X_VALUE, Y_VALUE, Z_VALUE, W_VALUE);
			Assert.AreEqual(W_VALUE, this.animator.GetFloat(this.parameter.WName));
			Assert.AreEqual(X_VALUE, this.animator.GetFloat(this.parameter.XName));
			Assert.AreEqual(Y_VALUE, this.animator.GetFloat(this.parameter.YName));
			Assert.AreEqual(Z_VALUE, this.animator.GetFloat(this.parameter.ZName));
		}
	}
}
