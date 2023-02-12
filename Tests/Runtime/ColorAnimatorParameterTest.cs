using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class ColorAnimatorParameterTest : AnimatorParameterTest
	{
		private ColorAnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<ColorAnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.RedName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.GreenName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.BlueName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.AlphaName, AnimatorControllerParameterType.Float);
		}

		[Test]
		public void ReadsColors()
		{
			const float RED_VALUE = 0.3f;
			const float GREEN_VALUE = 0.8f;
			const float BLUE_VALUE = 0f;
			const float ALPHA_VALUE = 1f;
			this.animator.SetFloat(this.parameter.RedName, RED_VALUE);
			this.animator.SetFloat(this.parameter.GreenName, GREEN_VALUE);
			this.animator.SetFloat(this.parameter.BlueName, BLUE_VALUE);
			this.animator.SetFloat(this.parameter.AlphaName, ALPHA_VALUE);
			Assert.AreEqual(new Color(RED_VALUE, GREEN_VALUE, BLUE_VALUE, ALPHA_VALUE), this.parameter.Value);
		}

		[Test]
		public void WritesColors()
		{
			const float RED_VALUE = 0.9f;
			const float GREEN_VALUE = 0.1f;
			const float BLUE_VALUE = 0.4f;
			const float ALPHA_VALUE = 0.3f;
			this.parameter.Value = new Color(RED_VALUE, GREEN_VALUE, BLUE_VALUE, ALPHA_VALUE);
			Assert.AreEqual(RED_VALUE, this.animator.GetFloat(this.parameter.RedName));
			Assert.AreEqual(GREEN_VALUE, this.animator.GetFloat(this.parameter.GreenName));
			Assert.AreEqual(BLUE_VALUE, this.animator.GetFloat(this.parameter.BlueName));
			Assert.AreEqual(ALPHA_VALUE, this.animator.GetFloat(this.parameter.AlphaName));
		}
	}
}
