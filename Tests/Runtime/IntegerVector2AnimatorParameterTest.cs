using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public class IntegerVector2AnimatorParameterTest : AnimatorParameterTest
	{
		private IntegerVector2AnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<IntegerVector2AnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.XName, AnimatorControllerParameterType.Int);
			this.AddParameter(this.parameter.YName, AnimatorControllerParameterType.Int);
		}

		[Test]
		public void ReadsVector2Ints()
		{
			const int XVALUE = 12;
			const int YVALUE = 35;
			this.animator.SetInteger(this.parameter.XName, XVALUE);
			this.animator.SetInteger(this.parameter.YName, YVALUE);
			Assert.AreEqual(new Vector2Int(XVALUE, YVALUE), this.parameter.Value);
		}

		[Test]
		public void WritesVector2Ints()
		{
			const int XVALUE = 78;
			const int YVALUE = 52;
			this.parameter.Value = new Vector2Int(XVALUE, YVALUE);
			Assert.AreEqual(XVALUE, this.animator.GetInteger(this.parameter.XName));
			Assert.AreEqual(YVALUE, this.animator.GetInteger(this.parameter.YName));
		}
	}
}
