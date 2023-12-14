using Godot;
using System.Collections.Generic;

namespace game
{
	public partial class StaticEntityList
	{
		public List<SingleEntity> Entities { get; private set; }
		private static StaticEntityList instance = null;

		public static StaticEntityList Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new StaticEntityList();
				}
				return instance;
			}
		}

		private StaticEntityList()
		{
			Entities = new List<SingleEntity>();
		}

		public void ReadAllEntities()
		{
			foreach (var entity in Entities)
			{
				GD.Print($"Entity Name: {entity.name}, ID: {entity.entityID}, X: {entity.x}, Y: {entity.y} Interactable: {entity.interactable}");
			}
		}
	}
}
