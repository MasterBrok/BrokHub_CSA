
using CSA.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Windows;

namespace CSA.Patterns
{
    public class PatternTag
    {

        #region Private Object
        private Content _content;
        private IList<string> _stringFrames;
        #endregion

        #region public Object
        public Content Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public List<Tag> GetTags
        {
            get => Frames();
        }
        #endregion

        public PatternTag()
        {
            _content = new Content();
            _stringFrames = new List<string>();
            //ConvertStrignToArray();
        }

        public PatternTag(Content content)
        {
            _content = content;
            _stringFrames = new List<string>();
            //ConvertStrignToArray();
        }

        #region Public Function
        public List<Tag> Frames()
        {
            List<Tag> _tags = new List<Tag>();
            try
            {
                ConvertStrignToArray();
                for (int i = 0; i < _stringFrames.Count; i++)
                {
                    _content.Animation.Value = _stringFrames[i];
                    _content.Animation.KeyTime = Time(TimeSpan.Parse(_content.Animation.KeyTime)).ToString(@"hh\:mm\:ss\.f");
                    _tags.Add(Frame());
                }
            }
            catch (Exception)
            {
            }
            return _tags;

        }
        #endregion

        #region private Function
        private Tag Frame()
        {
            // 0    1           2        3        4    5  6     7  8 9  10       11 
            // < Discrete CharKeyFrame KeyTime="0:0:0:1" Value="q" > </ Discrete CharKeyFrame >
            return Tag.GetTag(_content);
        }
        private TimeSpan Time(TimeSpan span)
        {
            try
            {
                span = span + TimeSpan.Parse(_content.Animation.JumpTime);
            }
            catch (Exception)
            {
            }
            return span;
        }
        private void ConvertStrignToArray()
        {
            // Example Brok
            // B
            // Br 
            // Bro
            // Brok
            for (int i = 1; i <= _content.Input?.Length; i++)
            {
                _stringFrames.Add(_content.Input.Substring(0, i));
            }
        }
        #endregion
    }
}
