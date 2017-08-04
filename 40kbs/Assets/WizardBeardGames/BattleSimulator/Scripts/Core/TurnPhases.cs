using System;

namespace WizardBeardGames.BattleSimulator.Core
{
	/// <summary>
	/// Turn phases.
	/// 
	/// Swithing on an enum is less expensive that using reflection to grab a Type.
	/// </summary>
	public enum TurnPhases
	{
		Movement,
		Psychic,
		Shooting,
		Charge,
		Fight,
		Morale
	}
}