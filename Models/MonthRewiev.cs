using System;
using System.Collections.Generic;

namespace Review.Models
{
    public partial class MonthRewiev
    {
        public int Id { get; set; }
        public int IndexStation { get; set; }
        public DateTime Date { get; set; }
        public double? Tmid { get; set; }
        public double? Tmax { get; set; }
        public double? Tmin { get; set; }
        public short? Tg { get; set; }
        public double? Rnight { get; set; }
        public double? Rday { get; set; }
        public short? Snow { get; set; }
        public short? BlastMaxSpeed { get; set; }
        public bool? Snowstorm { get; set; }
        public bool? Mist { get; set; }
        public bool? Hoarfrost { get; set; }
        public bool? GlazedFrost { get; set; }
        public bool? ThunderStorm { get; set; }
        public bool? ComplexFrost { get; set; }
    }
}
