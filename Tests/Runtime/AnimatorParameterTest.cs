using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

namespace dGameBoy101b.AnimatorParameters.Tests
{
	public abstract class AnimatorParameterTest
	{
		protected GameObject game_object;

		protected AnimatorController controller;

		protected Animator animator;

		[SetUp]
		public virtual void SetUp()
		{
			this.game_object = new GameObject();
			this.controller = new AnimatorController();
			this.controller.AddLayer("Base Layer");
			this.controller.layers[0].stateMachine.AddState("Default State");
			this.animator = this.game_object.AddComponent<Animator>();
			this.animator.runtimeAnimatorController = this.controller;
		}

		[TearDown]
		public virtual void TearDown()
		{
			Object.DestroyImmediate(this.game_object);
			Object.DestroyImmediate(this.controller);
		}

		protected void AddParameter(string name, AnimatorControllerParameterType type)
		{
			var parameter = new AnimatorControllerParameter();
			parameter.name = name;
			parameter.type = type;
			var parameters = new List<AnimatorControllerParameter>(this.controller.parameters);
			parameters.Add(parameter);
			this.controller.parameters = parameters.ToArray();
			this.animator.Rebind();
		}
	}
}