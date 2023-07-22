using BrokHub_CSA.BackendApplication.BaseICommand;
using BrokHub_CSA.BaseControls.ControlListBox;
using BrokHub_CSA.Validations;
using CSA.Enums;
using CSA.Models;
using CSA.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BrokHub_CSA.BackendApplication.ViewModels
{
    public class PageConvertViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void Notify(string Target)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(Target));
        }
        private List<EnumType> _listEnum;

        public List<EnumType> ListEnum
        {
            get { return _listEnum; }
            set { _listEnum = value; Notify(nameof(ListEnum)); }
        }

        public List<EnumType> ListType { get; } = Enum.GetValues(typeof(EnumType)).Cast<EnumType>().ToList();
        public List<EnumKeyFrames> ListFrame { get; } = Enum.GetValues(typeof(EnumKeyFrames)).Cast<EnumKeyFrames>().ToList();

        private string resultTag;

        public string ResultTag
        {
            get { return resultTag; }
            set { resultTag = value;Notify(nameof(ResultTag)); }
        }


        private Content _content;

        public Content Content
        {
            get { return _content; }
            set
            {
                _content = value;
                Notify(nameof(Content));
            }
        }
        private PatternTag _tag;

        public PatternTag Tag
        {
            get { return _tag; }
            set
            {
                _tag = value;
                Notify(nameof(Tag));
            }
        }

        public PageConvertViewModel()
        {
            Content = new Content();
            Tag = new PatternTag();
            Content.Animation = new Animation();
        }

        private ICommand _cmdCreateTag;

        public ICommand CmdCreateTag
        {
            get
            {
                if (_cmdCreateTag is null)
                    _cmdCreateTag = new BrokCommand(CreateTags_Click, CanCreateTag_Click);
                return _cmdCreateTag;
            }
        }

        private bool CanCreateTag_Click(object obj)
        {
            return !ValidateObject.IsNotNull(_content);
        }

        private void CreateTags_Click(object obj)
        {
            resultTag = "";
            _content.Animation.TypeFrame = (EnumType)Enum.Parse(typeof(EnumType), (((object[])obj)[0] as ListBox).SelectedItem.ToString());
            _content.Animation.EnumKey = (EnumKeyFrames)Enum.Parse(typeof(EnumKeyFrames), (((object[])obj)[1] as ListBox).SelectedItem.ToString());
            Tag.Content = _content;

            _tag.Frames().ForEach(f => resultTag += f.ToString() + "\n");

            Notify(nameof(Tag));
            Notify(nameof(Content));
            Notify(nameof(ResultTag));
            Tag = new();
        }
    }
}
