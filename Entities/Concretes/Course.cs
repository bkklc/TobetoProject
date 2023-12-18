﻿using Core.Entities;

namespace Entities.Concretes;

public class Course : Entity<int>
{
    public string ImageId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime EndDate { get; set; }
  
}
