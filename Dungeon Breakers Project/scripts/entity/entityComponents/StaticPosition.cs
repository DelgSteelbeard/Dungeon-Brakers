using Godot;
using System;

namespace x
{
	public partial class StaticPosition : Node2D
	{
		private string _turn;
		[Export]
		public int x { get; set; }
		[Export]
		public int y { get; set; }
		[Export]
		public string turn
		{
			get { return _turn; }
			set
			{
				turnValidation(_turn);
			}
		}

		private string turnValidation(string _turn)
		{
			if (_turn == "left" || _turn == "right" || _turn == "up" || _turn == "down")
			{
				return _turn;
			}
			else
			{
				GD.Print("Error: turn must be left, right, up or down");
				return "error";
			}
		}
	}
}