using GoogleSheet.Type;
using UnityEngine;
namespace Hamster.ZG.Type
{
    [Type(typeof(Color), new string[] { "color", "Color", "col" })]
    public class ColorType : IType
    {
        public object DefaultValue => Vector3.zero;
        /// <summary>
        /// value는 스프레드 시트에 적혀있는 값
        /// </summary> 
        public object Read(string value)
        {
            // value : [1,2,3,4] 
            var values = ReadUtil.GetBracketValueToArray(value);
            float r = float.Parse(values[0]);
            float g = float.Parse(values[1]);
            float b = float.Parse(values[2]);
            float a = float.Parse(values[3]);
            return new Color(r, g, b, a);
        }

        /// <summary>
        /// value write to google sheet
        /// </summary> 
        public string Write(object value)
        {
            Color v = (Color)value;
            return $"[{v.r},{v.g},{v.b},{v.a}]";
        }
    }
}