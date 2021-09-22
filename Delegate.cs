using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class InstanceClass<T> where T: InstanceClass<T>, new()
{
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new T();
                _instance.Init();
            }
            return _instance;
        }
        protected set
        {
            _instance = value;
        }
    }

    protected virtual void Init()
    {
        DebugLog();
    }

    public int privateValue;
    public void DebugLog()
    {
        Console.WriteLine($"{this.privateValue}");
    }

}


public sealed class Delegate : InstanceClass<Delegate>
{


}

