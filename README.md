# BrokHub_CSA
Converting String To Animation (CSA)


دیگ نیازی نیست برای Animation هات (String) بیایی بنویسی کد های خیلی زیاد . خیلی راحت با اپ نوشته هاتون به *StrignAnimation* تبدیل کن و کد شو بگیر

کافیه مدل ```Content``` رو پرش کنی مقدار ```Input``` رو ```Binding``` کنی. از مدل ```Animation``` هم پراپتی هاشو پر کنی .
```C#
Content content =  new ()
{
   Input = "Brok",
   Animation = new()
   {
      EnumKey = EnumKeyFrames.Discretem, // Spline or Discrete or Linear
      TypeFrame  = EnumType.StringKeyFrame, // StringKeyFrame or ThicknessKeyFrame or ColorKeyFrame
      KeyTime = "00:00:00", // Mask (00:00:00) ==> KeyValue
      JumpTime = "00:00:01" // Mask (00:00:00) ==> 00:00:01 => 1 Second , 00:00:00.3 => 3 Millisecond . . . .
    }
};
```
خب تا اینجا مقدار ها رو دادیم و تمام حالا برای اجرا از ```PatternTag``` استفاده میکنیم مقدار های یازگشتی  از نوع ```Tag``` هست . 
```C#
   PatternTag tags = new PatternTag();
   tags.Content = content;
```
کافیه تابع ```Frame``` رو فراخوانی کنی تا لیست از ```Tag``` برگردونه . و تمام
```C#
   return tags.Frames();
```


فعلا بخش ***StringAnimation*** رو نوشتم بقیه رو هم مینویسم.
