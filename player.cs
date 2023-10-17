using Godot;
using System;

public partial class player : CharacterBody2D
{
	private Vector2 m_velocity = Vector2.Zero;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello, World!");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	// Called every physics update of the game, by default it's 60u/s
	public override void _PhysicsProcess(double delta)
	{
		m_velocity.Y += 2.0f;

		if (Input.IsActionPressed("ui_right"))
		{
			m_velocity.X = 50.0f;
		}
		else if (Input.IsActionPressed("ui_left"))
		{
			m_velocity.X = -50.0f;
		}
		else
		{
			m_velocity.X = 0.0f;
		}

		Velocity = m_velocity;
		MoveAndSlide();
	}
}
