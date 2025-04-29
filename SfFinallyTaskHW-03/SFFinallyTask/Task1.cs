using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFFinallyTask;





public interface IAdder<in T>
{
    void Add(T num1, T num2);
}
public interface IResult<out T>
{
    T GetResult();
}

public class Calculator : IAdder<double>, IResult<double>
{
    private double _result;
    private ILogger _logger;
    public Calculator(ILogger logger)
    {
        _logger = logger;
    }
    public void Add(double num1, double num2)
    {
        _result = num1 + num2;
    }

    public double GetResult()
    {
        return _result;
    }
}
