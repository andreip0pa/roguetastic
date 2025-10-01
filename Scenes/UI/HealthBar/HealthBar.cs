using Godot;
public partial class HealthBar: Node3D
{
	[Export]
	public HealthComponent healthComponent;
	[Export]
	public ProgressBar progressBar;
	public override void _Process(double delta)
	{
		/*
		TODO Make it signal based instead of in _Process
		*/
		progressBar.MaxValue = healthComponent.MaxHealth;
		progressBar.Value = healthComponent.Health;
	}
}
