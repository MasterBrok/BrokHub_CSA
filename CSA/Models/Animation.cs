using CSA.Enums;

namespace CSA.Models
{
    public class Animation
    {
        /// <summary>
        /// KeyTime KeyFrams
        /// </summary>
        public float? JumpTime { get; set; }
        /// <summary>
        /// Value KeyFrames
        /// </summary>
        public object? Value { get; set; }
        /// <summary>
        /// Name KeyFrames
        /// </summary>
        public EnumAnimation? Name { get; set; }
        public EnumType? TypeFrame { get; set; }
        /// <summary>
        /// KeyFrames
        /// </summary>
        public EnumKeyFrames? EnumKey { get; set; } 
    }
}
