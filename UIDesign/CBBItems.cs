﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIDesign
{
    public class CBBItems
    {
        private int _Value;
        private string _Text;

        public int Value { get => _Value; set => _Value = value; }
        public string Text { get => _Text; set => _Text = value; }
        public override string ToString()
        {
            return Text;
        }
    }
}
