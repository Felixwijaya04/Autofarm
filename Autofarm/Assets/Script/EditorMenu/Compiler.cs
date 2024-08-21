using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseFunction : MonoBehaviour
{
    public abstract void Execute();
}

public class loop : BaseFunction
{
    public override void Execute()
    {
        Debug.Log("Looping..");
    }
}
public class Compiler : MonoBehaviour
{
    public List<BaseFunction> functions = new List<BaseFunction>();

    public void AddFunction(BaseFunction function)
    {
        functions.Add(function);
    }

    public void ExecuteAll()
    {
        foreach (var function in functions)
        {
            function.Execute();
        }
    }
}
