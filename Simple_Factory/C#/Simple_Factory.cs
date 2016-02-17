using System;

public class Operation
{
        private double _NumberA = 0;
        private double _NumberB = 0;

        public double NumberA
        {
                get {   return _NumberA;        }
                set {   _NumberA = value;       }
        }
        
        public double NumberB
        {
                get {   return _NumberB;        }
                set {   _NumberB = value;       }
        }
        
        public virtual double GetResult()
        {
                double result = 0;
                return result;
        }
}

class OperationAdd : Operation
{
        public override double GetResult()
        {
                return NumberA + NumberB;
        }
}

class OperationSub : Operation
{
        public override double GetResult()
        {
                return NumberA - NumberB;
        }
}

class OperationMul : Operation
{
        public override double GetResult()
        {
                return NumberA * NumberB;
        }
}

class OperationDiv: Operation
{
        public override double GetResult()
        {
                if (NumberB == 0)
                {
                        throw new Exception("除数不能为0。");
                }
                return NumberA / NumberB;
        }
}

public class OperationFactory
{
        public static Operation createOperate (string operate)
        {
                Operation oper = null;
                if (operate == "+"){
                        oper = new OperationAdd();
                }
                else if (operate == "-"){
                        oper = new OperationSub();
                }
                else if (operate == "*"){
                        oper = new OperationMul();
                }
                else if (operate == "/"){
                        oper = new OperationDiv();
                }

                return oper;
        }
}

// static void Main (string[] args){
//         Operation oper;
//         oper = OperationFactory.createOperate("+");
//         oper.NumberA = 1;
//         oper.NumberB = 2;
//         double result = oper.GetResult();
// }

public class Class1{
    public static void Main (string[] args){
        Operation oper;
        oper = OperationFactory.createOperate("+");
        oper.NumberA = 1;
        oper.NumberB = 2;
        double result = oper.GetResult();
        Console.WriteLine("args1: {0}", result);
    }
}
