using System;
using UnityEngine;

namespace WizardBeardGames.BattleSimulator.Core
{
	/// <summary>
	/// Base datasheet.
	/// 
	/// This should not be instantiated directly, but is
	/// the the direct GameObject ancestor of all Datasheet
	/// objects.
	/// </summary>
	public class BaseDatasheet : MonoBehaviour
	{
		public int movement;
		public int weaponSkill;
		public int ballisticsSkill;
		public int strenght;
		public int toughness;
		public int wounds;
		public int attacks;
		public int leadership;
		public int save;

		public bool hasInvulnerbleSave;
		public int invulnerableSave;

		// Use this for initialization
		void Start ()
		{

		}

		// Update is called once per frame
		void Update ()
		{

		}
	}
}

