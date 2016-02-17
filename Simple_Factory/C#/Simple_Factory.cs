public class Operation
{
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
                get {   return _numberA;        }
                set {   _numberA = value;       }
        }
        
        public double NumberB
        {
                get {   return _numberB;        }
                set {   _numberB = value;       }
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
                return numberA + numberB;
        }
}

class OperationSub : Operation
{
        public override double GetResult()
        {
                return numberA - numberB;
        }
}

class OperationMul : Operation
{
        public override double GetResult()
        {
                return numberA * numberB;
        }
}

class OperationDiv: Operation
{
        public override double GetResult()
        {
                if (numberB == 0)
                {
                        throw new Exception("除数不能为0。");
                }
                return numberA / numberB;
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
                else if (operation == "-"){
                        oper = new OperationSub();
                }
                else if (operation == "*"){
                        oper = new OperationMul();
                }
                else if (operation == "/"){
                        oper = new OperationDiv();
                }

                return oper;
        }
}

static void Main (string[] args){
        Operation oper;
        oper = OperationFactory.createOperate("+");
        oper.NumberA = 1;
        oper.NumberB = 2;
        double result = oper.GetResult();
}
