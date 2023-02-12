using NUnit.Framework;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class Vector3AnimatorParameterTest : AnimatorParameterTest
	{
		private Vector3AnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<Vector3AnimatorParameter>();
			this.parameter.ParameterName = "Test Parameter";
			this.parameter.Animator = this.animator;
			this.AddParameter(this.parameter.XName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.YName, AnimatorControllerParameterType.Float);
			this.AddParameter(this.parameter.ZName, AnimatorControllerParameterType.Float);
		}

		[Test]
		public void ReadsVector3s()
		{
			const float XVALUE = 1.2f;
			const float YVALUE = 3.4f;
			const float ZVALUE = 5.6f;
			this.animator.SetFloat(this.parameter.XName, XVALUE);
			this.animator.SetFloat(this.parameter.YName, YVALUE);
			this.animator.SetFloat(this.parameter.ZName, ZVALUE);
			Assert.AreEqual(new Vector3(XVALUE, YVALUE, ZVALUE), this.parameter.Value);
		}

		[Test]
		public void WritesVector3s()
		{
			const float XVALUE = 7.8f;
			const float YVALUE = 5.4f;
			const float ZVALUE = 9.2f;
			this.parameter.Value = new Vector3(XVALUE, YVALUE, ZVALUE);
			Assert.AreEqual(XVALUE, this.animator.GetFloat(this.parameter.XName));
			Assert.AreEqual(YVALUE, this.animator.GetFloat(this.parameter.YName));
			Assert.AreEqual(ZVALUE, this.animator.GetFloat(this.parameter.ZName));
		}
	}
}
