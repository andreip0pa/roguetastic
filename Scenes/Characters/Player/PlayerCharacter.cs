using Godot;
using System;
using System.Linq;

public partial class PlayerCharacter: Node3D
{

	[Export]
	public Node attackTarget;
	[Export]
	public HealthComponent healthComponent;
	public void Attack()
	{
		var healthComponent = attackTarget.GetChildren().Where(x => x is HealthComponent).First() as HealthComponent;
		if (healthComponent != null)
			healthComponent.TakeDamage(10);//TODO: Damage component 
	}
	public void GetAttacked()
	{
		healthComponent.TakeDamage(10);
	}
}
