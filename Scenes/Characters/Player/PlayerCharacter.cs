using Godot;
using System;
using System.Linq;

public partial class PlayerCharacter: Node3D
{

	[Export]
	public Node attackTarget;
	[Export]
	public HealthComponent healthComponent;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void Attack()
	{
		var healthComponent = attackTarget.GetChildren().Where(x => x is HealthComponent).First() as HealthComponent;
		if (healthComponent != null)
			healthComponent.TakeDamage(10);
	}

	public void GetAttacked()
	{
		healthComponent.TakeDamage(10);
	}
}
