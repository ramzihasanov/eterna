﻿namespace WebApplication1.Models
{
    public class Portfolio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public string ProjectUrl { get; set; }
        public string Client { get; set; }
        public DateTime ProjeDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
