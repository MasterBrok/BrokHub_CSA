namespace CSA.Enums
{
    /// <summary>
    /// This Enum For Tag Main Animation
    /// </summary>
    public enum EnumAnimation
    {
        StringAnimationUsingKeyFrames = 0,
        ThicknessAnimationUsingKeyFrames = 1,
        ColorAnimationUsingKeyFrames = 2
    }
    /// <summary>
    /// This Enum For Sub Tag Animation
    /// </summary>
    public enum EnumKeyFrames
    {
        Spline = 101,
        Discrete = 102,
        Linear = 103
    }
    /// <summary>
    /// This Enum For Name Sub Tag Animation
    /// </summary>
    public enum EnumType
    {
        StringKeyFrame,
        ThicknessKeyFrame,
        ColorKeyFrame,
    }
}
