using System;

namespace DTO
{
    public class dto_excell_imports
    {
        public string col_01 { get; set; } = "";
        public string col_02 { get; set; } = "";
        public string col_03 { get; set; } = "";
        public string col_04 => this.col_01 + " " + this.col_02;
    }
}
