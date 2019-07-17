using System;
using System.Collections.Generic;

namespace AutinoConnect.Data.CarVue.Models.Models
{
    public partial class FeatureConfig
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public string SettingName { get; set; }
        public string Value { get; set; }
    }
}
