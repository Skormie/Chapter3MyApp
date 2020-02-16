using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chapter2MyApp.Models
{
    public enum Type
    {
        INSECT,
        ANIMAL,
        PLANT,
        VIRUS,
        FUNGI
    }
    public class ActionModel
    {
        public int number { get; set; }
        public string name { get; set; }
        public Type what { get; set; }
    }
}