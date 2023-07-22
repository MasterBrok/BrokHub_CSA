
using CSA.Enums;
using CSA.Static;
using System;

namespace CSA.Models
{
    public class Tag
    {
        // 1    2         3          4         5        6     7  8 9   10       11          12 
        // < Discrete CharKeyFrame KeyTime= "0:0:0:2" Value= "d" > </ Discrete CharKeyFrame >


        // 1    2         3          4         5        6     7  8 
        // < Discrete CharKeyFrame KeyTime= "0:0:0:2" Value= "d" />
        public object? Part1 { get; set; }
        public object? Part2 { get; set; }
        public object? Part3 { get; set; }
        public object? Part4 { get; set; }
        public object? Part5 { get; set; }
        public object? Part6 { get; set; }
        public object? Part7 { get; set; }
        public object? Part8 { get; set; }
        public object? Part9 { get; set; }
        public object? Part10 { get; set; }
        public object? Part11 { get; set; }
        public object? Part12 { get; set; }

        public Tag()
        {

        }

        public static Tag GetTag(Content content)
        {
            Tag tag = new Tag()
            {
                Part1 = SR.TagOpenLeft,
                Part2 = content.Animation?.EnumKey,
                Part3 = content.Animation?.TypeFrame,
                Part4 = SR.KeyTime,
                Part5 = content.Animation?.KeyTime,
                Part6 = SR.Value,
                Part7 = content.Animation?.Value,
                Part8 = SR.TagCloseNow
            };
            return tag;
        }
        public override string ToString()
        {
            return
                String.Format
                (
                    "{0}{1}{2} {3}\"{4}\"  {5}\"{6}\" {7}",
                     Part1, Part2, Part3, Part4, Part5, Part6, Part7, Part8
                );
        }
    }
}
