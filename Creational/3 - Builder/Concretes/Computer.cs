using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Concretes
{
    public class Computer
    {
        public string CPU { get; set; } = default!;

        public string VideoCard { get; set; } = default!;

        public string RAM { get; set; } = default!;

        public string SSD { get; set; } = default!;

        public string HD { get; set; } = default!;

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Computer specs:");

            if (!string.IsNullOrEmpty(CPU))
                sb.AppendLine($"CPU: {CPU}");

            if (!string.IsNullOrEmpty(VideoCard))
                sb.AppendLine($"Video Card: {VideoCard}");

            if (!string.IsNullOrEmpty(RAM))
                sb.AppendLine($"RAM: {RAM}");

            if (!string.IsNullOrEmpty(SSD))
                sb.AppendLine($"SSD: {SSD}");

            if (!string.IsNullOrEmpty(HD))
                sb.AppendLine($"HD: {HD}");

            return sb.ToString();
        }
    }
}
