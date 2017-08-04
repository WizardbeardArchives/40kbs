using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardBeardGames.BattleSimulator.Core
{
	/// <summary>
	/// Base model.
	/// 
	/// It has to inherit form <see cref="UnityEngine.MonoBehaviour"/> but 
	/// shouldn't be instantiated directly.
	/// </summary>
	public class BaseModel : MonoBehaviour {

		public GameObject portrait2d;
		public GameObject portrait3d;

		// Use this for initialization
		void Start () {
				if (Debug.isDebugBuild) {
					Debug.Log ("Private ctor() invoked on: " + this.GetType().Name + " called by DeclaringType: " + this.GetType().DeclaringType);
				}
		}
	}
}