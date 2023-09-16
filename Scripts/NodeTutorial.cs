using Godot;
using System;

public partial class NodeTutorial : Sprite2D // 'Node' is an inheritance class. Kinda like 'MonoBehaviour' in unity (cringe)
{
	Godot.Sprite2D sprite;
	
	public override void _Ready()
	{
		sprite = GetNode<Godot.Sprite2D>("balls");
	}

	public override void _Process(double delta)
	{
		if(Input.IsKeyPressed(Key.W)) 
		{
			sprite.GlobalPosition = new Vector2(0,0);
		}
	}
}
