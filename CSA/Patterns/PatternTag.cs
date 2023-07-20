using CSA.Models;
using CSA.Static;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSA.Patterns
{
    public class PatternTag
    {
        private Content _content;
        private IList<string> _stringFrames;
        public PatternTag(Content content)
        {
            _content = content;
            _stringFrames= new List<string>();
            ConvertStrignToArray();
        }

        public string Frame()
        {
            // 0    1           2        3        4    5  6     7
            // < Discrete CharKeyFrame KeyTime="0:0:0:1" Value="q"></DiscreteCharKeyFrame>
            Tag tag = Tag.GetTag(_content);


            return tag.ToString();
        }

        internal void ConvertStrignToArray()
        {
            // Example Brok
            // B
            // Br 
            // Bro
            // Brok

            for (int i = 1; i <= _content.Input.Length; i++)
            {
                _stringFrames.Add(_content.Input.Substring(0, i));
            }
        }
        







    }
}
