using CSA.Models;

namespace BrokHub_CSA.Validations
{
    public class ValidateObject
    {
        public static bool IsNotNull(Content content)
        {
            return string.IsNullOrEmpty(content.Input)
                && string.IsNullOrEmpty(content.Animation?.JumpTime)
                && string.IsNullOrEmpty(content.Animation?.KeyTime) is true ? true : false;
        }
    }
}
