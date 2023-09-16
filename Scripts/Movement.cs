using Godot;
using System;
using System.Diagnostics;

public partial class Movement : Sprite2D
{

//[Export] with add these values into the hierarchy
	[Export] public float xVal; 
	[Export] public float yVal;
	
	public override void _Ready()
	{
	}

	
	public override void _Process(double delta)
	{
		if(Input.IsKeyPressed(Key.W))
		{
			this.Position += new Vector2(0,-yVal);
			Debug.Print("W is pressed");
		}
		if(Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, yVal);
			Debug.Print("S is pressed");
		}
		if(Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-xVal,0);
			Debug.Print("A is pressed");
		}
		if(Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(xVal,0);
			Debug.Print("D is pressed");
		}
	}
}
