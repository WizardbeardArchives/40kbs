using System;

namespace WizardBeardGames.BattleSimulator.Core
{
	/// <summary>
	/// Turn phases.
	/// 
	/// Switching on an enum is usually faster than using
	/// <see cref="System.Reflection"/> to gather Types and their
	/// names to do string comparisons.
	/// </summary>
	public enum TurnPhases
	{
		Movement,
		Psychic,
		Shooting,
		Charge,
		Fight,
		Morale,
	}
}

