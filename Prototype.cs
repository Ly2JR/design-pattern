using System.Text.Json;

namespace Design_Pattern
{
    /// <summary>
    /// 原型模式
    /// </summary>
    public  class Prototype
    {
        #region 浅复制
        //public interface IColor
        //{
        //    IColor Clone();

        //    int Red { get; set; }

        //    int Green { get; set; }

        //    int Blue { get; set; }
        //}

        //public class RedColor : IColor
        //{
        //    public int Red { get; set; }

        //    public int Green { get; set; }

        //    public int Blue { get; set; }

        //    public IColor Clone()
        //    {
        //        return (IColor)this.MemberwiseClone();
        //    }
        //}

        #endregion

        #region 深度复制

        public interface IColor
        {
            IColor? Clone();

            int Red { get; set; }

            int Green { get; set; }

            int Blue { get; set; }

            Factory? F { get; set; }
        }

        public class Factory
        {
            public string? Name { get; set; }
        }

        public class RedColor : IColor
        {
            public int Red { get; set; }
            public int Green { get; set; }
            public int Blue { get; set; }
            public Factory? F { get; set; }

            public IColor? Clone()
            {
                var json = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<RedColor>(json);
            }
        }

        #region  过时

        //public class SerializeHelper
        //{
        //    public string Serializable(object target)
        //    {
        //        using var stream = new MemoryStream();
        //        new BinaryFormatter().Serialize(stream, target);
        //        return Convert.ToBase64String(stream.ToArray());
        //    }

        //    public object DeserializeObject(string target)
        //    {
        //        var targetArray = Convert.FromBase64String(target);
        //        using var stream = new MemoryStream(targetArray);
        //        return new BinaryFormatter().Deserialize(stream);
        //    }

        //    public T Deserialize<T>(string target)
        //    {
        //        return (T)DeserializeObject(target);
        //    }
        //}

        #endregion

        #endregion
    }
}
