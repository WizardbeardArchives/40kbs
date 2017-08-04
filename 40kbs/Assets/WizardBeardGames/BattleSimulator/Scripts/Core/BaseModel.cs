using System;
using System.Collections.Generic;
using UnityEngine;

namespace WizardBeardGames.BattleSimulator.Core
{
	/// <summary>
	/// Base model.
	/// 
	/// This should not be instantiated directly, but is
	/// the the direct GameObject ancestor of all Mmodel
	/// objects.
	/// </summary>
	public class BaseModel : MonoBehaviour
	{
		// Public fields editable in the Unity Editor.
		public Sprite portrait2d;
		public GameObject portrait3d;
		public Factions faction;
		public List<Factions> FriendlyFactions;		// TODO: refactor into a FactionController
		public List<Factions> EnemyFactions;		// TODO: refactor into a FactionController

		// Use this for initialization
		void Start ()
		{
			if (Debug.isDebugBuild) {
				Debug.Log ("Started " + this.GetType().Name + " with Declaring Type: " + this.GetType().DeclaringType);
			}
		}

		// Update is called once per frame
		void Update ()
		{

		}
	}
}

