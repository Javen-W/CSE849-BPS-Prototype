using Godot;
using System;

namespace CSE870BPSPrototype
{
	public partial class UISignalBus : Node
	{
		[Signal] public delegate void GearChangedEventHandler(string gear);
		
		[Signal] public delegate void VelocityChangedEventHandler(float velocity);
		
		[Signal] public delegate void ObjectChangedEventHandler(StaticBody3D obj, float distance, bool proximity);
	
		public static void EmitGearChanged(string gear)
		{
			Instance.EmitSignal(nameof(GearChanged), gear);
		}

		public static void EmitVelocityChanged(float velocity)
		{
			Instance.EmitSignal(nameof(VelocityChanged), velocity);
		}

		public static void EmitObjectChangedEvent(StaticBody3D obj, float distance, bool proximity)
		{
			Instance.EmitSignal(nameof(ObjectChanged), obj, distance, proximity);
		}
		
		public static UISignalBus Instance { get; set; }
		
		// Called when the node enters the scene tree for the first time.
		public override void _Ready()
		{
			Instance = this;
		}
	}
}

