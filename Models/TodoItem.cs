// WHAT IS A MODEL? A model is a set of classes that represent the data that the app manages

using System;

namespace TodoApi.Models
{
	public class TodoItem
	{
		public long Id { get; set; }
		public string? Name{ get; set; }
		public bool IsComplete { get; set; }
    }
}
