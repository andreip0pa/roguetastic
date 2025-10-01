using Godot;
using System;

public partial class HealthBar: Node3D
{
	[Export]
	public HealthComponent healthComponent;
	[Export]
	public ProgressBar progressBar;
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		progressBar.MaxValue = healthComponent.MaxHealth;
		progressBar.Value = healthComponent.Health;
	}
}
