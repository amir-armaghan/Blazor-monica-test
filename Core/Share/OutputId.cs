using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Share
{
    public abstract class OutputId
    {
        public string DisplayName { get; set; }
        public int FromLayer { get; set; }
        public int Id { get; set; }
        public string JsonInput { get; set; }
        public int LayerAggOp { get; set; }
        public string Name { get; set; }
        public int Organ { get; set; }
        public int TimeAggOp { get; set; }
        public int ToLayer { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
    }
}
