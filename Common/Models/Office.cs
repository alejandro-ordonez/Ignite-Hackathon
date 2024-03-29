﻿
using System;
using System.Collections.Generic;
using System.Text;
namespace Common.Models
{
    public class Office
    {
        public int Id { get; set; }
        public int OfficeCod { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string BossName { get; set; }
        public string EmailBoss { get; set; }
        public int Atms { get; set; }
        public int NConsultants => Consultants.Count;
        public List<Record> Records { get; set; } = new List<Record>();
        public List<Consultant> Consultants { get; set; } = new List<Consultant>();
    }
}
