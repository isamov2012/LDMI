﻿namespace LWI.Views.Lwi
{
	public class DetailsVM
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string Price { get; set; }
		public string? DescriptionLong { get; set; }
		public string? ImgName { get; set; }
		public string? ImgAlt { get; set; }
		public string? Category { get; set; }
        public bool IsEco { get; set; }
        public bool InCart { get; set; }
    }
}
