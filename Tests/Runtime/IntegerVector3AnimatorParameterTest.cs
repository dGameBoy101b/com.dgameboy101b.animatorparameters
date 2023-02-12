using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public sealed class IntegerVector3AnimatorParameterTest : AnimatorParameterTest
	{
		private IntegerVector3AnimatorParameter parameter;

		[SetUp]
		public override void SetUp()
		{
			base.SetUp();
			this.parameter = this.game_object.AddComponent<IntegerVector3AnimatorParameter>();
			this.parameter.Animator = this.animator;
			this.parameter.ParameterName = "Test Parameter";
			this.AddParameter(this.parameter.XName, AnimatorControllerParameterType.Int);
			this.AddParameter(this.parameter.YName, AnimatorControllerParameterType.Int);
			this.AddParameter(this.parameter.ZName, AnimatorControllerParameterType.Int);
		}

		[Test]
		public void ReadsIntegerVector3s()
		{
			const int XVALUE = -12;
			const int YVALUE = 234;
			const int ZVALUE = -902;
			this.animator.SetInteger(this.parameter.XName, XVALUE);
			this.animator.SetInteger(this.parameter.YName, YVALUE);
			this.animator.SetInteger(this.parameter.ZName, ZVALUE);
			Assert.AreEqual(new Vector3Int(XVALUE, YVALUE, ZVALUE), this.parameter.Value);
		}

		[Test]
		public void WritesIntegerVector3s()
		{
			const int XVALUE = 349;
			const int YVALUE = -222;
			const int ZVALUE = -9002;
			this.parameter.Value = new Vector3Int(XVALUE, YVALUE, ZVALUE);
			Assert.AreEqual(XVALUE, this.animator.GetInteger(this.parameter.XName));
			Assert.AreEqual(YVALUE, this.animator.GetInteger(this.parameter.YName));
			Assert.AreEqual(ZVALUE, this.animator.GetInteger(this.parameter.ZName));
		}
	}
}
