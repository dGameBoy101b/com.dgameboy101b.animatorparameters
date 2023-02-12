using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class Vector2AnimatorParameterTest : AnimatorParameterTest
	{
		private Vector2AnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<Vector2AnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.XName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.YName, AnimatorControllerParameterType.Float);
		}

		[Test]
		public void ReadsVector2s()
		{
			const float XVALUE = 3.4f;
			const float YVALUE = 5.6f;
			this.animator.SetFloat(this.parameter.XName, XVALUE);
			this.animator.SetFloat(this.parameter.YName, YVALUE);
			Assert.AreEqual(new Vector2(XVALUE, YVALUE), this.parameter.Value);
		}

		[Test]
		public void WritesVector2s()
		{
			const float XVALUE = 7.8f;
			const float YVALUE = 3.2f;
			this.parameter.Value = new Vector2(XVALUE, YVALUE);
			Assert.AreEqual(XVALUE, this.animator.GetFloat(this.parameter.XName));
			Assert.AreEqual(YVALUE, this.animator.GetFloat(this.parameter.YName));
		}
	}
}
