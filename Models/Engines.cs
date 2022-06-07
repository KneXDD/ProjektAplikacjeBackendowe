﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameHelperApp.Models;

public class Engines
{
    [Key]
    public int EngineId { get; set; }

    public string Name { get; set; }
    
    [DisplayName("Release Date")]
    public DateTime ReleaseDate { get; set; }

    public string Developer { get; set; }

    public string License { get; set; }

    [DisplayName("Engine Description")]
    public string EngineDescription { get; set; }

    [DisplayName("Engine Logo")]
    public Byte[] EngineLogo { get; set; }
    
}