using System;
namespace Inheritance
{
	public class Reptiles : Animal
	{
		public Reptiles()
		{
		}

		bool HasBackBones { get; set; }
		bool HasScales { get; set; }
		bool ColdBlooded { get; set; }
		bool OneLungAtLeast { get; set; }

	}
}

