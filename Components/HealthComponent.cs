using Godot;
using System;

[GlobalClass]
[Icon("res://Resources/Assets/heart-icon.svg")]
public partial class HealthComponent: Node
{
	[ExportGroup("Health")]
	[Export]
	public int MaxHealth = 100;
	[Export]
	public int Health = 100;
	#region Signals
	[Signal]
	public delegate void HealthChangedEventHandler(int newHealth);

	[Signal]
	public delegate void TookDamageEventHandler(int damage);
	[Signal]
	public delegate void DiedEventHandler();
	#endregion
	public void TakeDamage(int damage)
	{
		this.Health -= damage;
		EmitSignal(SignalName.HealthChanged, this.Health);
		EmitSignal(SignalName.TookDamage, damage);
		if (this.Health <= 0)
			Die();


	}
	public void Die()
	{
		EmitSignal(SignalName.Died);
	}
}
