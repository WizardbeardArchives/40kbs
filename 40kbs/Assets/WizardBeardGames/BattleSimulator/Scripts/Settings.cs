using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WizardBeardGames.BattleSimulator
{
	public class Settings : MonoBehaviour
	{
		public string gameName;

		public void PrintName ()
		{
			Debug.Log ("Hello, " + name);
		}

		public void PrintGameName ()
		{
			Debug.Log ("Hello, " + gameName);
		}

		// Use this for initialization
		void Start ()
		{
			PrintName ();
			PrintGameName ();
		}
	}
}